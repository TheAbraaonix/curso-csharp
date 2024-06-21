using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.section_10.ExercicioMetodosAbstratos.Entities;
using CursoCsharp.section_10.ExercicioMetodosAbstratos.Entities.Enums;

namespace CursoCsharp.section_10.ExercicioMetodosAbstratos
{
    internal class ExercicioMetodosAbstratosMain
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i + 1} data:");

                Console.Write("Rectangle or circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color Black/Blue/Red: ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine());

                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine());

                    list.Add(new Rectangle(color, width, height));
                } else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    list.Add(new Circle(color, radius));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}
