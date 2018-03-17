using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var sciezka = @"c:\temp\moj.plik";
            File.Copy(sciezka, @"d:\temp\moj.plik", true);
            File.Delete(sciezka);
            if (File.Exists(sciezka))
            {
                //cos tu mozna zrobic
            }
            var zawartosc = File.ReadAllText(sciezka);

            var fileInfo = new FileInfo(sciezka);
            fileInfo.CopyTo("cokolwiek tutaj");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //cos do zrobienia
            }

        }
    }
}
