using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionBarDb;
namespace FunctionBar.Forme
{
    public partial class StatistikaForm : Form
    {
        public StatistikaForm()
        {
            InitializeComponent();
        }

        private void StatistikaForm_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
            txtDanasnja.ReadOnly = true;
            txtMjesecna.ReadOnly = true;
            txtTjedna.ReadOnly = true;
        }

        private void OsvjeziPodatke()
        {
            DanasnjaZarada();
            TjednaZarada();
            MjesecnaZarada();
        }

        private void MjesecnaZarada()
        {
            var prijeMjesecDana = DateTime.Now.Date.AddDays(-30);
            var sutrasnjiDatumUPonoc = DateTime.Now.Date.AddDays(1);
            float ukupnaZarada = 0;
            using (var context = new FunctionBarDB())
            {
                var query = from r in context.racuns.Where(x => x.datum >= prijeMjesecDana && x.datum < sutrasnjiDatumUPonoc && (x.storniran == false || x.storniran == null))
                            join z in context.zaposleniks on r.id_zaposlenik equals z.OIB
                            join s in context.stavka_racuna on r.ID equals s.id_racun
                            join a in context.artikls on s.id_artikl equals a.ID
                            select new
                            {
                                Račun = r.ID,
                                Datum = r.datum,
                                Iznos = a.cijena * s.kolicina
                            };
                foreach (var x in query)
                {
                    ukupnaZarada += (float)x.Iznos;
                }
               
                txtMjesecna.Text = ukupnaZarada.ToString();
            }
        }

        private void TjednaZarada()
        {
            var prijeTjedanDana = DateTime.Now.Date.AddDays(-7);
            var sutrasnjiDatumUPonoc = DateTime.Now.Date.AddDays(1);
            float ukupnaZarada = 0;
            using (var context = new FunctionBarDB())
            {
                var query = from r in context.racuns.Where(x =>x.datum > prijeTjedanDana && x.datum < sutrasnjiDatumUPonoc && (x.storniran == false || x.storniran == null))
                            join z in context.zaposleniks on r.id_zaposlenik equals z.OIB
                            join s in context.stavka_racuna on r.ID equals s.id_racun
                            join a in context.artikls on s.id_artikl equals a.ID
                            select new
                            {
                                Račun = r.ID,
                                Datum = r.datum,
                                Iznos = a.cijena * s.kolicina
                            };
                foreach (var x in query)
                {
                    
                    ukupnaZarada += (float)x.Iznos;
                }
                
                txtTjedna.Text = ukupnaZarada.ToString();
            }
        }

        private void DanasnjaZarada()
        {
            var danasnjiDatumUPonoc = DateTime.Now.Date;
            var sutrasnjiDatumUPonoc = danasnjiDatumUPonoc.AddDays(1);
            float ukupnaZarada = 0;
           using (var context=new FunctionBarDB())
            {
                var query = from r in context.racuns.Where(x => x.datum> danasnjiDatumUPonoc && x.datum < sutrasnjiDatumUPonoc && (x.storniran == false || x.storniran == null))
                            join z in context.zaposleniks on r.id_zaposlenik equals z.OIB
                            join s in context.stavka_racuna on r.ID equals s.id_racun
                            join a in context.artikls on s.id_artikl equals a.ID
                            select new
                            {
                                Račun = r.ID,
                                Datum = r.datum,
                                Iznos = a.cijena * s.kolicina
                            };
                foreach(var x in query)
                {
                    ukupnaZarada += (float)x.Iznos;
                }
                txtDanasnja.Text = ukupnaZarada.ToString();
                
            }
        }
    }
}
