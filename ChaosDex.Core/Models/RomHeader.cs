using System;
using System.Collections.Generic;
using System.Text;

namespace ChaosDex.Core.Models
{
    public class RomHeader
    {
        public string GameTitle { get; }
        public string GameCode { get; }
        public string MakerCode { get; }
        public int Version { get; }

        public RomHeader(string gameTitle, string gameCode, string makerCode, int version)
        {
            GameTitle = gameTitle;
            GameCode = gameCode;
            MakerCode = makerCode;
            Version = version;
        }
    }
}
