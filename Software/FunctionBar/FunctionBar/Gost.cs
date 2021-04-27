using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class Gost
    {
        public int ID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string kontakt { get; set; }
        public Gost(int id, string ime, string prezime, string kontakt)
        {
            this.ID = id;
            this.ime = ime;
            this.prezime = prezime;
            this.kontakt = kontakt;
        }
    }
}
