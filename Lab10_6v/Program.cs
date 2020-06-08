using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace lab10_6v
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "./file.txt";
            WriteData(path);
            var text = ReadData(path);

            Console.Write("Слова из текстового файла, состоящие только из больших латинских букв: ");
            foreach (var str in text)
            {
                if (CheckString(str))
                {
                    Console.Write($"{str} ");
                }
            }
        }

        static bool CheckString(string str)
        {
            var chars = str.ToCharArray();
            foreach (var chr in chars)
            {
                if (!char.IsUpper(chr)) return false;
            }
            return true;
        }

        static void WriteData(string path)
        {
            var text = "LOREM ipsum dolor sit AMET, consectetur adipiscing ELIT, sed DO eiusmod tempor " + 
                " incididunt UT labore et DOLORE MAGNA ALIQUIA. Ut enim ad minim veniam, QUIS nostrud exercitation " + 
                " ullamco LABORIS NISI ut aliquip ex ea COMMODO consequat. DUIS aute IRURE dolor in reprehenderit in " + 
                " voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, " + 
                " sunt in culpa qui officia deserunt mollit anim id est LABORUM.";

            using (FileStream fs = File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(text);
                fs.Write(info, 0, info.Length);
            }

        }

        static List<string> ReadData(string path)
        {
            var result = new List<string>();
     
            using (StreamReader sr = File.OpenText(path))
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    result.AddRange(s.Split(' ', ',', '.'));
                }
            }
            return result;
        }
    }
}