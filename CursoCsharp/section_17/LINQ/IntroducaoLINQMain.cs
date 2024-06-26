using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_17.LINQ
{
    internal class IntroducaoLINQMain
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            // Define the query expression
            var result = numbers.Where((n) => n % 2 == 0).Select(n => n * 10);
            
            // Execute the query
            foreach( int n in result )
            {
                Console.WriteLine(n);
            }
        }
    }
}
