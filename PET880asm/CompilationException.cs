using System;
using System.Runtime.Serialization;

namespace PET880asm
{
    [Serializable]
    public class CompilationException : Exception
    {
        public int Line { get; protected set; }
        public int Column { get; protected set; }
        
        public CompilationException(int line, int col) : this(line, col, "", null)
        {
        }

        public CompilationException(int line, int col, string message) : this(line, col, message, null)
        {
        }

        public CompilationException(int line, int col, string message, Exception inner) : base(message, inner)
        {
            Line = line;
            Column = col;
        }
    }
}