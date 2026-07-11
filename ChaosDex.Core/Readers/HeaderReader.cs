using ChaosDex.Core.Constants;
using ChaosDex.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChaosDex.Core.Readers
{
    public static class HeaderReader
    {
        public static RomHeader ReadHeader(Rom rom)
        {
            string gameTitle = ReadAscii(rom.Data, GBAHeader.GameTitleOffset, GBAHeader.GameTitleLength);
            string gameCode = ReadAscii(rom.Data, GBAHeader.GameCodeOffset, GBAHeader.GameCodeLength);
            string makerCode = ReadAscii(rom.Data, GBAHeader.MakerCodeOffset, GBAHeader.MakerCodeLength);
            int version = rom.Data[GBAHeader.VersionOffset];

            return new RomHeader(gameTitle, gameCode, makerCode, version);
        }

        private static string ReadAscii(byte[] data,int offset,int length)
        {
            byte[] asciiWord = new byte[length];
            for(int i = 0; i < length; i++)
            {
                asciiWord[i] = data[offset + i]; 
            }

            return Encoding.ASCII.GetString(asciiWord).TrimEnd('\0');
        }
    }
}
