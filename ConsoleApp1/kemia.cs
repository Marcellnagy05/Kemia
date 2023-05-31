using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class kemia
    {
        private string ev;
        private string nev;
        private string vegyjel;
        private int rendszam;
        private string felfedezo;


        public kemia(string line)
        {
            string[] adatok = line.Split(';');
            Ev = adatok[0];
            Nev = adatok[1];
            Vegyjel = adatok[2];
            Rendszam = int.Parse(adatok[3]);
            Felfedezo = adatok[4];
        }
        public string Ev { get => ev; set => ev = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Vegyjel { get => vegyjel; set => vegyjel = value; }
        public int Rendszam { get => rendszam; set => rendszam = value; }
        public string Felfedezo { get => felfedezo; set => felfedezo = value; }
    }
}
