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
            NajprodavanijiArtikli();
            NajjeftinijiArtikli();
            NajskupljiArtikli();
            KriticniArtikli();
            NajneprodavanijiArtikli();
        }


        //top 5 najneprodavanijih artikala
        private void NajneprodavanijiArtikli()
        {
            var trenutniDatum = DateTime.Now;
            using (var context = new FunctionBarDB())
            {
                var query = from r in context.racuns.Where(x => x.datum < trenutniDatum && (x.storniran == false || x.storniran == null))
                            join s in context.stavka_racuna on r.ID equals s.id_racun
                            select new
                            {
                                s.id_racun,
                                s.id_artikl,
                                s.kolicina
                            };
                var query2 = from s in query
                             group s by s.id_artikl into g
                             select new { Id = g.Key, Suma = g.Sum(x => x.kolicina) };
                var query3 = from a in context.artikls
                             join g in query2 on a.ID equals g.Id
                             orderby g.Suma ascending
                             select new
                             {
                                 Naziv = a.naziv,
                                 Kolicina = g.Suma
                             };
                query3 = query3.Take(5);
                najmanjeProdaniGraf.Series["Kolicina"].Points.Clear();
                foreach (var item in query3)
                {
                    najmanjeProdaniGraf.Series["Kolicina"].Points.AddXY(item.Naziv, item.Kolicina);
                }
            }
        }

        //prikazuje sve artikle cija je kolicina na zalihi manja od 8
        private void KriticniArtikli()
        {
          using (var context=new FunctionBarDB())
            {
                var query = from artikl in context.artikls
                           where (artikl.kolicina_na_zalihi >= 0 && artikl.kolicina_na_zalihi <= 8)
                           select new
                           {
                               Naziv = artikl.naziv,
                               Preostalo = artikl.kolicina_na_zalihi
                           };
                dgvKriticni.DataSource = query.ToList();
            }
        }

        //uzima top 5 najskupljih artikala
        private void NajskupljiArtikli()
        {
            using (var context=new FunctionBarDB())
            {
                var query = from artikl in context.artikls.OrderByDescending(x => x.cijena).Take(5)
                            select new
                            {
                                Artikl = artikl.naziv,
                                Cijena = artikl.cijena
                            };
                dgvNajskuplji.DataSource = query.ToList();
                          
            }
        }

        //prikazuje top 5 najjeftinijih artikla
        private void NajjeftinijiArtikli()
        {
            using (var context = new FunctionBarDB())
            {
                var query = from artikl in context.artikls.OrderBy(x => x.cijena).Take(5)
                            select new
                            {
                                Artikl = artikl.naziv,
                                Cijena = artikl.cijena
                            };
                dgvNajjeftiniji.DataSource = query.ToList();

            }
        }


        //graf prikazuje top 6 najprodavanijih artikala
        //query2 sumira kolicinu, dok query3 uzima naziv i kolicinu artikala
        //pomocu metode Take(6) uzima se top 6 najprodavanijih artikala
        private void NajprodavanijiArtikli()
        {
            var trenutniDatum = DateTime.Now;
            using (var context=new FunctionBarDB())
            {
                var query = from r in context.racuns.Where(x => x.datum < trenutniDatum && (x.storniran == false || x.storniran == null))
                            join s in context.stavka_racuna on r.ID equals s.id_racun
                            select new
                            {
                                s.id_racun,
                                s.id_artikl,
                                s.kolicina
                            };
                var query2 = from s in query
                             group s by s.id_artikl into g
                             select new { Id = g.Key, Suma = g.Sum(x => x.kolicina) };
                var query3 = from a in context.artikls
                             join g in query2 on a.ID equals g.Id
                             orderby g.Suma descending
                             select new
                             {
                                 Naziv = a.naziv,
                                 Kolicina = g.Suma
                             };
               query3 = query3.Take(6);
                vrstePicaGraf.Series["Kolicina"].Points.Clear();
                foreach(var item in query3)
                {
                    vrstePicaGraf.Series["Kolicina"].Points.AddXY(item.Naziv, item.Kolicina);
                }
            }
        }

        //racuna tjednu zaradu 
        //usporeduje datum prije 30 dana u ponoc i sutrasnji datum u ponoc te uzima sve racune koji su izdani izmedu ta dva datuma
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

        //racuna tjednu zaradu 
        //usporeduje datum prije 7 dana u ponoc i sutrasnji datum u ponoc te uzima sve racune koji su izdani izmedu ta dva datuma
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

        //racuna danasnju zaradu 
        //usporeduje danasnji datum u ponoc i sutrasnji datum u ponoc te uzima sve racune koji su izdani izmedu ta dva datuma
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vrstePicaGraf_Click(object sender, EventArgs e)
        {

        }

        private void StatistikaForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string helpPoveznica = "FunctionBarHelp.chm";
            Help.ShowHelp(this, Environment.CurrentDirectory + "\\Resources\\" + helpPoveznica, HelpNavigator.Topic, "start.htm#_Toc43663416");
        }
    }
}
