using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_15.DesafioHashSetAndSortedSet
{
    internal class MainDesafioHashSetAndSortedSet
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students are in course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter student {i + 1} code: ");
                int code = int.Parse(Console.ReadLine());
                courseA.Add(code);
            }

            Console.Write("How many students are in course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter student {i + 1} code: ");
                int code = int.Parse(Console.ReadLine());
                courseB.Add(code);
            }

            Console.Write("How many students are in course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter student {i + 1} code: ");
                int code = int.Parse(Console.ReadLine());
                courseC.Add(code);
            }

            HashSet<int> allStudents = new HashSet<int>(courseA);

            allStudents.UnionWith(courseB);
            allStudents.UnionWith(courseC);

            Console.WriteLine($"Number of students: {allStudents.Count()}");
        }
    }
}
