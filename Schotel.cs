using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KopjeEnSchotel
{
    internal class Schotel
    {
        public string kleur;
        public bool opdruk;
        public string locatie;
        public Kop kop;

        public Schotel(string _kleur, bool _opdruk, string _locatie)
        {
            kleur = _kleur;
            opdruk = _opdruk;   
            locatie = _locatie; 
        }
    }
}
