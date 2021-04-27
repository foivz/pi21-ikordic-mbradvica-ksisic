using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class VrstaStola
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public VrstaStola(int id, string naziv)
        {
            this.ID = id;
            this.Naziv = naziv;
        }
    }
}
