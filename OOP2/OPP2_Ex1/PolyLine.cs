using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2_Ex1
{
     class PolyLine : Shape
    {
        private int[] xPoints;
        private int[] yPoints;

        public PolyLine(int[] xPoints, int[] yPoints) : base(0, 0)
        {
            this.xPoints = xPoints;
            this.yPoints = yPoints;
        }

        public override void Show()
        {
            Console.Write("Polyline with points:");
            for (int i = 0; i < xPoints.Length; i++)
            {
                Console.Write($" ({xPoints[i]},{yPoints[i]})");
            }
            Console.WriteLine();
        }
    }
}
