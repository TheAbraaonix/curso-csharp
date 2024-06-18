using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharp.section_6.matriz.desafio
{
    internal class DesafioMatrizMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as dimensões da sua matriz: ");
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine($"Digite os valores da linha {i + 1}:");
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Digite um número da matriz:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == number)
                    {
                        Console.WriteLine($"A posição do número {number} é: {i}, {j}");
                        Console.WriteLine("Vizinhos:");
                        Console.WriteLine(" ");

                        if (j > 0)
                        {
                            Console.WriteLine($"Esquerda: {mat[i, j - 1]}");
                        }

                        if (i > 0)
                        {
                            Console.WriteLine($"Cima: {mat[i - 1, j]}");
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine($"Direita: {mat[i, j + 1]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Baixo: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
