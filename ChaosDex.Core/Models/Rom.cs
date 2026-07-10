using System;
using System.Collections.Generic;
using System.Text;

namespace ChaosDex.Core.Models
{
    public class Rom
    {
        public string FileName { get; }
        public string FilePath { get; }
        public byte[] Data { get; }
        public int Size => Data.Length;

        public Rom(string fileName,string filePath, byte[] data)
        {
            FileName = fileName;
            FilePath = filePath;
            Data = data;
            
        }
    }
}
