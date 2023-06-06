using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doziranje_lekova
{
    internal class Lekovi
    {
        public string Ime { get; set; }
        public string TipLeka { get; set; }
        public double JacinaDoze { get; set; }


        public Lekovi(string Ime, string TipLeka, double JacinaDoze)
        {
            this.Ime = Ime;
            this.TipLeka = TipLeka;
            this.JacinaDoze = JacinaDoze; 

        }
    }
}