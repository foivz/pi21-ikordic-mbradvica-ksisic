using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class VrstaUloge
    {
        public int ID { get; set; }
        public string Naziv { get; set; }

        public VrstaUloge(int id, string naziv)
        {
            this.ID = id;
            this.Naziv = naziv;
        }
    }
}
