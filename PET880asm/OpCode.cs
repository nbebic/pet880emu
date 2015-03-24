using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ReSharper disable InconsistentNaming

namespace PET880asm
{
    enum OpCode
    {
        NOP   = 0x00,   // NOP
              
        ADD   = 0x01,   // IXY
        SUB   = 0x02,
        CMP   = 0x03,
        AND   = 0x04,
        OR    = 0x05,
        XOR   = 0x06,
              
        NEG   = 0x07,   // IX
        CPL   = 0x08,
        INC   = 0x09,
        DEC   = 0x0a,
        SHL   = 0x0b,
        SHR   = 0x0c,
        ROL   = 0x0d,
        ROR   = 0x0e,
              
        LEA   = 0x0f,   // IXC
              
        MOVE  = 0x10,   // IXY
        LOAD  = 0x11,
        STORE = 0x12,

        JUMP  = 0x13,   // IC
        JZ    = 0x14,
        JNZ   = 0x15,
        JC    = 0x16,
        JNC   = 0x17,
        JM    = 0x18,
        JP    = 0x19,
        INT   = 0x1a
    }
}
