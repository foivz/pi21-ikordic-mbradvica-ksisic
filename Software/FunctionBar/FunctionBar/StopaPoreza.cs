using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class StopaPoreza
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public StopaPoreza(int id, string naziv, string opis)
        {
            this.Naziv = naziv;
            this.ID = id;
            this.Opis = opis;
        }

    }
}
