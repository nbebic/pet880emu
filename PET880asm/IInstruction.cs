using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PET880asm
{
    interface IInstruction
    {
        byte Opcode { get; }
        byte[] Bytes { get; }
    }

    class NOP : IInstruction
    {
        public byte Opcode
        {
            get { return (byte) OpCode.NOP; }
        }

        public byte[] Bytes
        {
            get { return new[] {(byte) OpCode.NOP}; }
        }
    }

    class InstructionXY : IInstruction
    {
        private OpCode _opcode;
        private byte _xreg;
        private byte _yreg;

        public byte Opcode
        {
            get { return (byte)_opcode; }
        }

        public byte[] Bytes
        {
            get { return new []{(byte)_opcode, (byte)((_yreg & 3) | ((_xreg & 3) << 4))}; }
        }

        public InstructionXY(OpCode opcode, byte rx, byte ry)
        {
            _opcode = opcode;
            _xreg = rx;
            _yreg = ry;
        }
    }

    class InstructionX : InstructionXY
    {
        public InstructionX(OpCode opcode, byte rx) : base(opcode, rx, 0)
        {
                
        }
    }

    class InstructionXC : IInstruction
    {
        private OpCode _opcode;
        private byte _xreg;
        private byte _const;

        public byte Opcode
        {
            get { return (byte) _opcode; }
        }

        public byte[] Bytes
        {
            get { return new[] {(byte) _opcode, (byte) ((_xreg & 3) << 4), _const}; }
        }

        public InstructionXC(OpCode opcode, byte rx, byte c)
        {
            _opcode = opcode;
            _xreg = rx;
            _const = c;
        }
    }

    class InstructionJump : IInstruction
    {
        private OpCode _opcode;

        public byte Address;

        public string Label { get; protected set; }

        public byte Opcode
        {
            get { return (byte) _opcode; }
        }

        public byte[] Bytes
        {
            get { return new[] { (byte) _opcode, Address }; }
        }

        public InstructionJump(OpCode opcode, string label)
        {
            _opcode = opcode;
            Label = label;
        }

    }
}
