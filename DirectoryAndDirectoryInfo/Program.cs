using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\";
            var sciezka = @"C:\Users\programowanie\source\repos\";
            Directory.CreateDirectory(path+"1"+"2");

            var files = Directory.GetFiles(sciezka, "*.cs*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
