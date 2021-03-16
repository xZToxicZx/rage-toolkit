/*
    Copyright(c) 2017 Neodymium

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
*/

using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
    // datBase
    // ptxShaderVar
    public class ShaderVar : DatBase64, IResourceXXSystemBlock
    {
        public override long BlockLength => 24;

        // structure data
        public ulong Unknown_8h; // 0x0000000000000000
        public uint Hash;
        public byte Type;
        public byte Unknown_15h;
        public ushort Unknown_16h;

        /// <summary>
        /// Reads the data-block from a stream.
        /// </summary>
        public override void Read(ResourceDataReader reader, params object[] parameters)
        {
            base.Read(reader, parameters);

            // read structure data
            this.Unknown_8h = reader.ReadUInt64();
            this.Hash = reader.ReadUInt32();
            this.Type = reader.ReadByte();
            this.Unknown_15h = reader.ReadByte();
            this.Unknown_16h = reader.ReadUInt16();
        }

        /// <summary>
        /// Writes the data-block to a stream.
        /// </summary>
        public override void Write(ResourceDataWriter writer, params object[] parameters)
        {
            base.Write(writer, parameters);

            // write structure data
            writer.Write(this.Unknown_8h);
            writer.Write(this.Hash);
            writer.Write(this.Type);
            writer.Write(this.Unknown_15h);
            writer.Write(this.Unknown_16h);
        }

        public IResourceSystemBlock GetType(ResourceDataReader reader, params object[] parameters)
        {
            reader.Position += 20;
            var type = reader.ReadByte();
            reader.Position -= 21;

            switch (type)
            {
                case 2:
                case 4: return new ShaderVarVector();
                case 6: return new ShaderVarTexture();
                case 7: return new ShaderVarKeyframe();
                default: throw new Exception("Unknown shader var type");
            }
        }
    }
}
