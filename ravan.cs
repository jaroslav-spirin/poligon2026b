using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026B
{
    internal static class ravan
    {
        public static int saistestrane(vektor v, tacka a, tacka b)
        {
            vektor va = new vektor(v.poc, a);
            vektor vb = new vektor(v.poc, b);
            double ap = vektor.vektorski(v, va);
            double bp = vektor.vektorski(v, vb);
            if (ap * bp > 0) return 0;
            else if (ap * bp == 0) return 1;
            else return -1;
        }
    }
}
