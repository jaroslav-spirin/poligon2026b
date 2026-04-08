using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026B
{
    internal class vektor
    {
        public tacka poc, kraj;
        public vektor(tacka poc, tacka kraj)
        {
            this.poc = poc;
            this.kraj = kraj;
        }
        public vektor(tacka kraj)
        {
            this.poc = new tacka();
            this.kraj = kraj;
        }
        public tacka centriraj()
        {
            return new tacka(kraj.x-poc.x,kraj.y-poc.y);
        }
        public void stampaj()
        {
            Console.WriteLine("pocetak:({0},{1}), kraj:({2},{3})", poc.x, poc.y, kraj.x, kraj.y);
        }
        public static double skalarni(vektor a, vektor b)
        {
            tacka a1 = a.centriraj();
            tacka b1 = b.centriraj();
            return a1.x * b1.x + a1.y * b1.y;
        }
        public static double vektorski(vektor a, vektor b)
        {
            tacka a1 = a.centriraj();
            tacka b1 = b.centriraj();
            return a1.x * b1.y - a1.y * b1.x;
        }
        public double duzina()
        {
            return centriraj().d();
        }
        public static bool sekuse(vektor a, vektor b)
        {
            if (ravan.saistestrane(a, b.poc, b.kraj) * ravan.saistestrane(b, a.poc, a.kraj) != 0)
            {
                Console.WriteLine("{0},{1};{2},{3};;{4},{5};{6},{7}", a.poc.x, a.poc.y, a.kraj.x, a.kraj.y, b.poc.x, b.poc.y, b.kraj.x, b.kraj.y);
                return true;
            }
            else return false;
        }
    }
}
