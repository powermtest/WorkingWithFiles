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
            //Directory.CreateDirectory(path+"1"+"2");

            //var files = Directory.GetFiles(sciezka, "*.sln", SearchOption.AllDirectories);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            var directories = Directory.GetDirectories(sciezka, "*.*", searchOption:SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
            
            var dirifo = new DirectoryInfo(sciezka);
            dirifo.GetFiles();
            dirifo.GetDirectories();
            
        }
    }
}
