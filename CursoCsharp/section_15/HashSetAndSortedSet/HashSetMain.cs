using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_15.HashSet
{
    internal class HashSetMain
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Table");

            Console.WriteLine(set.Contains("notebook"));

            foreach (string s in set) { Console.WriteLine(s); }
        }
    }
}
