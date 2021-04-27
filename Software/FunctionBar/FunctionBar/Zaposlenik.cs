using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class Zaposlenik
    {
        public int OIB { get; set; }
        public string datumRodenja { get; set; }
        public string adresa { get; set; }
        public string strucnaSprema { get; set; }
        public string slikaPutanja { get; set; }
        public VrstaUloge uloga { get; set; }

        public Zaposlenik(int oib, string datum, string adresa, string strucnaSprema, string slikaPutanja, VrstaUloge uloga)
        {
            this.OIB = oib;
            this.datumRodenja = datum;
            this.adresa = adresa;
            this.strucnaSprema = strucnaSprema;
            this.slikaPutanja = slikaPutanja;
            this.uloga = uloga;
        }


    }
}
