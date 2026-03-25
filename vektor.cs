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
        public vektor centriraj()
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
    }
}
