using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2_Ex1
{
     class Circle : Shape
    {
        private int radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override void Show()
        {
            Console.WriteLine($"Circle with center at ({x},{y}) and radius {radius}");
        }
    }
}
