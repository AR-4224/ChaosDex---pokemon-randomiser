using System;
using System.Collections.Generic;
using System.Text;

namespace ChaosDex.Core.Models
{
    public class Rom
    {
        public string FileName { get; set; }

        public string FilePath { get; set; }

        public byte[] Data { get; set; }

        public int Size => Data.Length;

        public Rom(string fileName,string filePath, byte[] data)
        {
            FileName = fileName;
            FilePath = filePath;
            Data = data;
            
        }
    }
}
