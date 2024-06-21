using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCsharp.section_10.ExercicioMetodosAbstratos.Entities.Enums;

namespace CursoCsharp.section_10.ExercicioMetodosAbstratos.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }
        
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
