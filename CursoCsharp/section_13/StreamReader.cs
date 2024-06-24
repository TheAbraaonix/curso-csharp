using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_13
{
    internal class StreamReader
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\teste\file1.txt";
            
            FileStream fs = null;
            System.IO.StreamReader sr = null;

            try
            {
                fs = new FileStream(sourcePath, FileMode.Open);
                sr = new System.IO.StreamReader(fs);

                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }
    }
}
