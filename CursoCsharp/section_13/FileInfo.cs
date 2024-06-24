using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_13
{
    internal class FileInfo
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\teste\file1.txt";
            string targetPath = @"C:\teste\file2.txt";

            try
            {
                System.IO.FileInfo fileInfo = new System.IO.FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
