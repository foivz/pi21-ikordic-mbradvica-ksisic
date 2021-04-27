using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBar
{
    public class Artikl
    {
        public int ID { get; set; }
        public string naziv { get; set; }
        public float cijena { get; set; }
        public float normativ { get; set; }
        public float kolicinaNaZalihi { get; set; }
        public float nabavnaCijena { get; set; }
        public VrstaArtikla vrstaArtikla { get; set; }
        public StopaPoreza stopaPoreza { get; set; }
        public Artikl(int id, string naziv, float cijena, float normativ, float kolicinaNaZalihi, float nabavnaCijena, VrstaArtikla vrsta, StopaPoreza stopa)
        {
            this.ID = id;
            this.naziv = naziv;
            this.cijena = cijena;
            this.normativ = normativ;
            this.kolicinaNaZalihi = kolicinaNaZalihi;
            this.nabavnaCijena = nabavnaCijena;
            this.vrstaArtikla = vrsta;
            this.stopaPoreza = stopa;
        }
    }
}
