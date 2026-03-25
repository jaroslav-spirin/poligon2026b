using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon2026B
{
    internal class poligon
    {
        int br_temena;
        tacka[] teme;
        public poligon(int n)
        {
            br_temena = n;
            teme = new tacka[n];
        }
        public static poligon unos()
        {
            Console.Write("Unesite broj temena: ");
            int br = Convert.ToInt32(Console.ReadLine());
            poligon novi = new poligon(br);
            for(int i = 0; i < br; i++)
            {
                novi.teme[i] = new tacka();
                Console.Write("teme #{0}.x = ", i+1);
                novi.teme[i].x = Convert.ToDouble(Console.ReadLine());
                Console.Write("teme #{0}.y = ", i+1);
                novi.teme[i].y = Convert.ToDouble(Console.ReadLine());
            }
            return novi;
        }
        public void stampaj()
        {
            Console.WriteLine("Poligon sa {0} temena: ", br_temena);
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("teme #{0} ({1},{2})", i + 1, teme[i].x, teme[i].y);
            }
        }
        public void snimi()
        {
            StreamWriter sw = new StreamWriter("poligon.txt");
            sw.WriteLine(br_temena);
            for (int i = 0; i < br_temena; i++)
            {
                sw.WriteLine(teme[i].x);
                sw.WriteLine(teme[i].y);
            }
            sw.Close();
        }
        static public poligon ucitaj()
        {
            StreamReader sr = new StreamReader("poligon.txt");
            int br = Convert.ToInt32(sr.ReadLine());
            poligon novi = new poligon(br);
            for (int i = 0; i < br; i++)
            {
                novi.teme[i] = new tacka();
                novi.teme[i].x = Convert.ToDouble(sr.ReadLine());
                novi.teme[i].y = Convert.ToDouble(sr.ReadLine());
            }
            sr.Close();
            return novi;
        }
    }
}
