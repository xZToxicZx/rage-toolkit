﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RageLib.Resources.RDR2.PC.Drawables
{
    public class Struct_19 : ResourceSystemBlock
    {
        public override long BlockLength => 0x40;

        // structure data
        public ulong VFT;                   // 0x0000000140912C48
        public ulong Unknown_08h_Pointer;
        public ulong Unknown_10h_Pointer;
        public ulong Unknown_18h;           // 0x0000000000000000
        public ulong Unknown_20h;           // 0x0000000000000000
        public uint Unknown_28h;
        public ushort Unknown_2Ch;
        public ushort Unknown_2Eh;
        public uint Unknown_30h;
        public uint Unknown_34h;
        public ulong Unknown_38h;			// 0x0000000000000000

        // reference data
        public Struct_17 Unknown_08h_Data;
        public Struct_14 Unknown_10h_Data;


        public override void Read(ResourceDataReader reader, params object[] parameters)
        {
            // read structure data


            // read reference data
        }

        public override void Write(ResourceDataWriter writer, params object[] parameters)
        {
            // write structure data


            // write reference data
        }
    }
}
