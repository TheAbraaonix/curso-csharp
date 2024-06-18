using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_6.arrayList
{
    internal class ArrayListMain
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string item in list)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("List Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            int p1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position A: " + p1);

            int p2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position A: " + p2);

            List<String> resultsFilter = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            foreach (string item in resultsFilter)
            {
                Console.WriteLine(item);
            }

            list.Remove("Alex");
            Console.WriteLine("---------------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);

            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);

            }

            list.RemoveAt(0);
            Console.WriteLine("---------------------");
            foreach (string item in list)
            {
                Console.WriteLine(item);

            }
        }
    }
}
