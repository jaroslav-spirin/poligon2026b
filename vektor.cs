using System;
using System.Collections.Generic;
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
            poc = new tacka(0, 0);
            this.kraj = kraj;
        }
        public vektor centriraj()
        {
            return new vektor(new tacka(kraj.x-poc.x,kraj.y-poc.y));
        }
        public void stampaj()
        {
            Console.WriteLine("pocetak:({0},{1}), kraj:({2},{3})", poc.x, poc.y, kraj.x, kraj.y);
        }
    }
}
