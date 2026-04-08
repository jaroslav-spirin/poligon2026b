using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*tacka a = new tacka(2, 3);
            tacka b = new tacka(4, 5);
            tacka c = new tacka(6, 7);
            tacka d = new tacka(8, 9);
            vektor ab = new vektor(a, b);
            ab.stampaj();*/
            /*poligon p = poligon.unos();
            p.stampaj();
            p.snimi();*/
            /*poligon p = poligon.ucitaj();
            p.stampaj();*/
            poligon p = poligon.unos();
            Console.WriteLine(p.povrsina());
            //Console.WriteLine(vektor.sekuse(new vektor(new tacka(2,6), new tacka(2,4)),new vektor(new tacka(1,1),new tacka(5,1))));
        }
    }
}
