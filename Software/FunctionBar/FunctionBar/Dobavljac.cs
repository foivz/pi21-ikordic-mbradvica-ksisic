using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class Dobavljac
    {
        public int OIB { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string IBAN { get; set; }
        public Dobavljac(int oib, string naziv, string adresa, string iban)
        {
            this.OIB = oib;
            this.Naziv = naziv;
            this.Adresa = adresa;
            this.IBAN = iban;
        }
    }
}
