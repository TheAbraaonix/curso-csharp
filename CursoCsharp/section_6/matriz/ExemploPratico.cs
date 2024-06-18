using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_6.matriz
{
    internal class ExemploPratico
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o tamanho da sua matriz NxN?");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Insira os valores da linha {i + 1}");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine("");

            int qtdNegativos = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        qtdNegativos++;
                    }
                }
            }

            Console.WriteLine($"Quantidade de números negativos: {qtdNegativos}");
        }
    }
}
