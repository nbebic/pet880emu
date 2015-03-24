using System.Collections.Generic;
using System.IO;
using System;
using System.CodeDom;
using System.Runtime.InteropServices;

namespace PET880asm
{
    public class Assembler
    {
        private readonly StreamReader _inFile;
        private readonly FileStream _outFile;
        private int _line;
        private byte[] _buffer;
        private int _ip;
        private Dictionary<string, byte> _labels = new Dictionary<string, byte>(); 

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
            int col = comm.IndexOf(':');
            if (col >= 0)
            {
                
            }
        }
    }
}