using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doziranje_lekova
{
    internal class Pacijent
    {
        public int Id { get; set; } 
        public string Ime { get; set; }

        public Pacijent (int id, string ime)
        {
            Id = id;
            Ime = ime;
        }       
    }
}
