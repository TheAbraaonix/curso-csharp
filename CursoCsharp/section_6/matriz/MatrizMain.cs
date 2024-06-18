using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_6.matriz
{
    internal class MatrizMain
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);
            Console.WriteLine("Qtd linhas: " + mat.Rank);
            Console.WriteLine("Primeira propridade (linha): " + mat.GetLength(0));
            Console.WriteLine("Segunda propridade (coluna): " + mat.GetLength(1));
        }
    }
}
