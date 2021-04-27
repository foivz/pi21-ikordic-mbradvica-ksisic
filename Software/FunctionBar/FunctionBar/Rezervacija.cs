using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class Rezervacija
    {
        public int ID { get; set; }

        public DateTime datumZaprimanja { get; set; }
        public DateTime datumRezervacije { get; set; }
        public Zaposlenik zaposlenik { get; set; }
        public Gost gost { get; set; }
        public Rezervacija(int id, DateTime datumZaprimanja, DateTime datumRezervacije, Zaposlenik zaposlenik, Gost gost)
        {
            this.ID = id;
            this.datumRezervacije = datumRezervacije;
            this.datumZaprimanja = datumZaprimanja;
            this.zaposlenik = zaposlenik;
            this.gost = gost;
        }
    }
}
