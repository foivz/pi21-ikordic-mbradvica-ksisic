using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class StavkaNarudzbe
    {
        public Artikl artikl { get; set; }
        public Narudzbenica narudzbenica { get; set; }
        public int kolicina { get; set; }
        public StavkaNarudzbe(Artikl artikl, Narudzbenica narudzbenica, int kolicina)
        {
            this.artikl = artikl;
            this.narudzbenica = narudzbenica;
            this.kolicina = kolicina;
        }
    }
}
