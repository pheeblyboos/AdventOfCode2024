using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    internal class FileLoaderService
    {
        public static string LoadFile(string fileName)
        {
            return File.ReadAllText(@$"{Directory.GetCurrentDirectory()}\Input\{fileName}.txt");
           
        }
    }
}
