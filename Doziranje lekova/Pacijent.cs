using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doziranje_lekova
{
    internal class Pacijent
    {
        public string IdPacijenta { get; set; } 
        public string Ime { get; set; }

        public Pacijent (string id, string ime)
        {
            IdPacijenta = id;
            Ime = ime;
        }       
    }
}
