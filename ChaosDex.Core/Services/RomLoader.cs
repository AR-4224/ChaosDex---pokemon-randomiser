using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ChaosDex.Core.Models;
using System.Runtime.CompilerServices;

namespace ChaosDex.Core.Services
{
    public static class RomLoader
    {
        public static Rom Load(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("ROM file not found:" + path);
            }
           
            byte[] fileBytes = File.ReadAllBytes(path);
            string fileName = Path.GetFileName(path);

            return new Rom(fileName, path, fileBytes);
        }

    }
}
