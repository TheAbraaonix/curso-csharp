﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_11
{
    internal class TryCatchMain
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divisio by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }
    }
}
