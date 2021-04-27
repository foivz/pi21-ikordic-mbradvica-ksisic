using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class Stol
    {
        public int ID { get; set; }
        public int brojMjesta { get; set; }
        public Rezervacija rezervacija { get; set; }
        public VrstaStola vrstaStola { get; set; }
        public Stol(int id, int brojmjesta, Rezervacija rezervacija, VrstaStola vrstaStola)
        {
            this.ID = id;
            this.brojMjesta = brojmjesta;
            this.rezervacija = rezervacija;
            this.vrstaStola = vrstaStola;
        }
    }
}
