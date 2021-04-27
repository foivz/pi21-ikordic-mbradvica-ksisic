using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class StavkaRacuna
    {
        public Racun racun { get; set; }
        public Artikl artikl { get; set; }
        public int kolicina { get; set; }
        public StavkaRacuna(Racun racun, Artikl artikl, int kolicina)
        {
            this.racun = racun;
            this.artikl = artikl;
            this.kolicina = kolicina;
        }
    }
}
