using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            for (int i = 0; i < br; i++)
            {
                novi.teme[i] = new tacka();
                Console.Write("teme #{0}.x = ", i + 1);
                novi.teme[i].x = Convert.ToDouble(Console.ReadLine());
                Console.Write("teme #{0}.y = ", i + 1);
                novi.teme[i].y = Convert.ToDouble(Console.ReadLine());
            }
            return novi;
        }
        public vektor[] stranice()
        {
            vektor[] niz = new vektor[br_temena];
            for (int i = 0; i < br_temena; i++)
            {
                niz[i] = new vektor(teme[i], teme[(i + 1) % br_temena]);
            }
            return niz;
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
        public double obim()
        {
            double rez = 0;
            foreach (vektor stranica in stranice())
            {
                rez += stranica.duzina();
            }
            return rez;
        }
        public bool prost()
        {
            for (int i = 0; i < br_temena - 1; i++)
            {
                for (int j = i + 1; j < br_temena; j++)
                {
                    if (teme[i] == teme[j])
                    {
                        return false;
                    }
                }
            }
            vektor[] stranice = this.stranice();
            for (int i = 0; i < br_temena - 2; i++)
            {
                for (int j = i + 2; j < br_temena - Convert.ToInt32(i == 0); j++)
                {
                    if (vektor.sekuse(stranice[i], stranice[j])) return false;
                }
            }
            return true;
        }
        public bool konveksan()
        {
            vektor[] stranice = this.stranice();
            int n = 0;
            for (int i = 0; i < br_temena; i++)
            {
                if (vektor.vektorski(stranice[i], stranice[(i + 1) % br_temena]) > 0) n++;
            }
            if (n == 0 || n == br_temena) return true;
            else return false;
        }
        public double povrsina()
        {
            if (prost())
            {
                double desno = 0, levo = 0;
                for (int i = 0; i < br_temena; i++)
                {
                    desno += teme[i].x * teme[(i + 1) % br_temena].y;
                    levo += teme[(i + 1) % br_temena].x * teme[i].y;
                }
                return Math.Abs(desno - levo) / 2;
            }
            else return 0;
        }
        public bool deltoid()
        {
            if (br_temena != 4) return false;
            if (vektor.skalarni(new vektor(teme[0], teme[2]), new vektor(teme[1], teme[3])) == 0) return true;
            else return false;
        }
        public bool kvadrat()
        {
            if (br_temena != 4) return false;
            vektor[] stranice = this.stranice();
            if (stranice[0].duzina() == stranice[1].duzina() && stranice[1].duzina() == stranice[2].duzina() && stranice[2].duzina() == stranice[3].duzina())
            {
                if (vektor.skalarni(new vektor(teme[0], teme[1]), new vektor(teme[1], teme[2])) == 0) return true;
                else return false;
            }
            else return false;
        }
        public bool pravougaonik()
        {
            if (br_temena != 4) return false;
            vektor[] stranice = this.stranice();
            if (stranice[0].duzina() == stranice[2].duzina() && stranice[1].duzina() == stranice[3].duzina())
            {
                if (vektor.skalarni(new vektor(teme[0], teme[1]), new vektor(teme[1], teme[2])) == 0) return true;
                else return false;
            }
            else return false;
        }
    }
}
