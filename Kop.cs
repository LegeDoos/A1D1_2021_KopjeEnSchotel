using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KopjeEnSchotel
{
    internal class Kop
    {
        public string kleur;
        public Schotel schotel;
        public bool opdruk;
        public bool oor;
        public string inhoud;

        //private int hoeveelheid;
        //public int Hoeveelheid
        //{
        //    get { return hoeveelheid; }
        //    private set { hoeveelheid = value;}
        //}
        // dit is hetzelfde als bovenstaande regels:
        public int Hoeveelheid { get; private set; }

        public Kop(string _kleur, bool _opdruk, bool _oor, string _inhoud, int _hoeveelheid)
        {
            kleur = _kleur;
            opdruk = _opdruk;
            oor = _oor;
            inhoud = _inhoud;
            Hoeveelheid = _hoeveelheid;
        }

        public void Vullen(int _aantalMl)
        {
            if (Hoeveelheid + _aantalMl < 200)
            {
                Hoeveelheid = Hoeveelheid + _aantalMl;
            }
            else
            {
                Hoeveelheid = 200;
            }
            //Console.WriteLine($"De inhoud van mijn kopje is {this.hoeveelheid}");
        }


    }
}
