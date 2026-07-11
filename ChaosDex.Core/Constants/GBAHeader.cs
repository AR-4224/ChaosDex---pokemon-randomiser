using System;
using System.Collections.Generic;
using System.Text;

namespace ChaosDex.Core.Constants
{
    public static class GBAHeader
    {
        public const int GameTitle = 0x0A;
        public const int GameTitleLength = 12;

        public const int GameCodeOffset = 0xAC;
        public const int GameCodeLength = 4;

        public const int MakerCodeOffset = 0xB0;
        public const int MakerCodeLength = 2;
    }
}
