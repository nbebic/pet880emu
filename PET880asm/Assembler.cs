using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom;
using System.Linq;
using System.Runtime.InteropServices;

namespace PET880asm
{
    public class Assembler
    {
        private readonly StreamReader _inFile;
        private readonly FileStream _outFile;
        private int _line;
        private byte[] _buffer;
        private byte _ip;
        private Dictionary<string, byte> _labels = new Dictionary<string, byte>(); 
        private Dictionary<byte, string> _jumps = new Dictionary<byte, string>();

        public Assembler(string inPath, string outPath)
        {
            _inFile = File.OpenText(inPath);
            _outFile = File.OpenWrite(outPath);
        }

        public void Translate()
        {
            _line = 0;
            _ip = 0;
            _buffer = new byte[255];
            while (!_inFile.EndOfStream)
            {
                _line++;
                string strline = _inFile.ReadLine();
                if (strline == null) break;
                string comm = strline.Split(';')[0];
                translate_comm(comm);
            }
        }

        public void ResReferences()
        {
            throw new NotImplementedException();
        }

        public void GenerateOutput()
        {
            throw new NotImplementedException();
        }

        private void translate_comm(string comm)
        {
            if (comm == "") return;
            var col = comm.IndexOf(':');
            if (col >= 0)
            {
                // Imamo labelu
                string label = comm.Substring(0, col);
                if (_labels.ContainsKey(label)) 
                    throw new CompilationException(_line, 0, string.Format("Duplicate label {0}", label));
                _labels.Add(label, _ip);
                comm = comm.Substring(col, comm.Length - col);
            }
            comm = comm.Trim();
            OpCode op;
            string ops = comm.TakeWhile(char.IsLetter).ToString().ToUpper();
            if (!Enum.TryParse(ops, out op))
                throw new CompilationException(_line, 0, string.Format("Unknown opcode {0}", ops));
            string[] args = comm.Substring(ops.Length, comm.Length - ops.Length).Split(',').Select(t => t.Trim()).ToArray();

            switch (op)
            {
                case OpCode.NOP:    // NOP
                    _buffer[_ip++] = 0;
                    break;

                case OpCode.ADD:    // IXY
                case OpCode.SUB:
                case OpCode.CMP:
                case OpCode.AND:
                case OpCode.OR:
                case OpCode.XOR:
                case OpCode.MOVE:
                case OpCode.LOAD:
                case OpCode.STORE:
                    if (args.Length != 2)
                        throw new CompilationException(_line, 0, string.Format("Wrong number of arguments to {0}", op));
                    IInstruction ins1 = new InstructionXY(op, decode_register(args[0]), decode_register(args[1]));
                    foreach (byte t in ins1.Bytes)
                        _buffer[_ip++] = t;
                    break;

                case OpCode.NEG:    // IX
                case OpCode.CPL:
                case OpCode.INC:
                case OpCode.DEC:
                case OpCode.SHL:
                case OpCode.SHR:
                case OpCode.ROL:
                case OpCode.ROR:
                    if (args.Length != 1)
                        throw new CompilationException(_line, 0, string.Format("Wrong number of arguments to {0}", op));
                    IInstruction ins2 = new InstructionX(op, decode_register(args[0]));
                    foreach (byte t in ins2.Bytes)
                        _buffer[_ip++] = t;
                    break;

                case OpCode.LEA:    // IXC
                    if (args.Length != 2)
                        throw new CompilationException(_line, 0, string.Format("Wrong number of arguments to {0}", op));
                    IInstruction ins3;
                    if (char.IsDigit(args[1][0]))
                    {
                        byte ix;
                        if (!byte.TryParse(args[1], out ix))
                            throw new CompilationException(_line, 0, string.Format("Wrong number format {0}", args[1]));

                        ins3 = new InstructionXC(op, decode_register(args[0]), ix);
                        foreach (var b in ins3.Bytes)
                            _buffer[_ip++] = b;

                    }
                    else
                    {
                        ins3 = new InstructionXC(op, decode_register(args[0]), 0);
                        _buffer[_ip++] = ins3.Bytes[0];
                        _buffer[_ip++] = ins3.Bytes[1];
                        _jumps.Add(_ip++, args[1]);
                    }
                    break;
                case OpCode.JUMP:   // IC
                case OpCode.JZ:  
                case OpCode.JNZ: 
                case OpCode.JC:  
                case OpCode.JNC: 
                case OpCode.JM:  
                case OpCode.JP:  
                case OpCode.INT:
                    if (args.Length != 2)
                        throw new CompilationException(_line, 0, string.Format("Wrong number of arguments to {0}", op));
                    IInstruction ins4 = new InstructionXC(op, decode_register(args[0]), 0);
                    _buffer[_ip++] = ins4.Bytes[0];
                    _buffer[_ip++] = ins4.Bytes[1];
                    _jumps.Add(_ip++, args[1]);
                    break;
            }
        }

        private byte decode_register(string register)
        {
            switch (register.ToUpper())
            {
                case "R0":
                    return 0;
                case "R1":
                    return 1;
                case "R2":
                    return 2;
                case "R3":
                    return 3;
                default:
                    throw new CompilationException(_line, 0, string.Format("Unknown register {0}", register));
            }
        }
    }
}