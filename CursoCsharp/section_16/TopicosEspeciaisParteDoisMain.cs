using CursoCsharp.section_16.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_16
{
    internal class TopicosEspeciaisParteDoisMain
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2003, 02, 13, 12, 15, 0);
            Console.WriteLine(dt.ElapsedTime());

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
