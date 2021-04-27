using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class Racun
    {
        public int ID { get; set; }
        public DateTime datum { get; set; }
        public Zaposlenik zaposlenik { get; set; }
        public Racun(int id, DateTime datum, Zaposlenik zaposlenik)
        {
            this.ID = id;
            this.datum = datum;
            this.zaposlenik = zaposlenik;
        }
    }
}
