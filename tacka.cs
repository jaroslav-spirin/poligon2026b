using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026B
{
    internal class tacka
    {
        double x, y;
        public tacka(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
