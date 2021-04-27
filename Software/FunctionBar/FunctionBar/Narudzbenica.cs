using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class Narudzbenica
    {
        public int ID { get; set; }
        public DateTime datumNarudzbe { get; set; }
        public DateTime datumZaprimanja { get; set; }
        public Dobavljac dobavljac { get; set; }
        public Zaposlenik zaposlenik { get; set; }
        public Narudzbenica(int id, DateTime datumNarudzbe, DateTime datumZaprimanja, Zaposlenik zaposlenik)
        {
            this.ID = id;
            this.datumNarudzbe = datumNarudzbe;
            this.datumZaprimanja = datumZaprimanja;
            this.zaposlenik = zaposlenik;
          
        }
    }
}
