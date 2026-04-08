using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026B
{
    internal class tacka
    {
        public double x, y;
        public tacka(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public tacka()
        {
            x = 0; y = 0;
        }
        public double d()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public static bool operator ==(tacka a, tacka b)
        {
            if (a.x == b.x && a.y == b.y) return true;
            else return false;
        }
        public static bool operator !=(tacka a, tacka b)
        {
            if (a.x == b.x && a.y == b.y) return false;
            else return true;
        }
        public override bool Equals(object o)
        {
            if (this == (tacka)o) return true;
            else return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
