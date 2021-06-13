using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionBarDb;
namespace FunctionBar.Forme
{
    public partial class ZaprimanjeRobe : Form
    {
        public ZaprimanjeRobe()
        {
            InitializeComponent();
        }

    
        //dodavanje vrijednosti u combobox i pozivanje metode Osvjezi koja dohvaca sve narudzbenice
        private void ZaprimanjeRobe_Load(object sender, EventArgs e)
        {
            Osvjezi(0);
            cbFilterNarudzbenice.Items.Add("Nezaprimljene");
            cbFilterNarudzbenice.Items.Add("Zaprimljene");
            cbFilterNarudzbenice.SelectedIndex = 0;
        }


        
        private void Osvjezi(int cbVrijednost)
        {
            dgvNarudzbenice.DataSource = null;
            dgvNarudzbenice.DataSource = DohvatiNarudzbenice(cbVrijednost);
        }


        //Dohvacanje narudzbenica iz baze, ukoliko je cbVrijednost 0, dohvaćaju se one narudzbenice koje se nisu zaprimile
        //ukoliko je cbVrijednost 1, dohvacaju se narudzbenice kojima je datum zaprimanja !=null, odnosno one koje su zaprimljene
        private object DohvatiNarudzbenice(int cbVrijednost)
        {
            if (cbVrijednost==0) {
                using (var context=new FunctionBarDB())
                {
                    var upit = from narudzbenica in context.narudzbenicas
                               join zaposlenik in context.zaposleniks on narudzbenica.id_zaposlenik equals zaposlenik.OIB
                               join dobavljac in context.dobavljacs on narudzbenica.id_dobavljac equals dobavljac.OIB
                               where narudzbenica.datum_zaprimanja == null
                               select new
                               {
                                   Broj_narudzbenice = narudzbenica.ID,
                                   DatumNarudžbe = narudzbenica.datum_narudzbe,
                                   Dobavljac = dobavljac.naziv,
                                   Obavio_narudžbu = zaposlenik.ime + " " + zaposlenik.prezime
                               };
                    return upit.ToList();
                }
            }
            else
                using (var context = new FunctionBarDB())
                {
                    var upit = from narudzbenica in context.narudzbenicas
                               join zaposlenik in context.zaposleniks on narudzbenica.id_zaposlenik equals zaposlenik.OIB
                               join dobavljac in context.dobavljacs on narudzbenica.id_dobavljac equals dobavljac.OIB
                               where narudzbenica.datum_zaprimanja != null
                               select new
                               {
                                   Broj_narudzbenice = narudzbenica.ID,
                                   DatumNarudžbe = narudzbenica.datum_narudzbe,
                                   Dobavljac = dobavljac.naziv,
                                   Obavio_narudžbu = zaposlenik.ime + " " + zaposlenik.prezime
                               };
                    return upit.ToList();
                }
        }

        //s obzirom na odabranu narudzbenicu, dohvaćaju se njezine stavke (prema id-u)
        private void dgvNarudzbenice_SelectionChanged(object sender, EventArgs e)
        {
            var id = dgvNarudzbenice.CurrentRow.Cells[0].Value;
            dgvStavke.DataSource = DohvatiStavkeNarudzbe((int)id);
        }

        private object DohvatiStavkeNarudzbe(int id)
        {
            using (var context = new FunctionBarDB())
            {
                var upit = from stavka in context.stavka_narudzbe
                           join artikl in context.artikls on stavka.id_artikl equals artikl.ID
                           where stavka.id_narudzbenica == id
                           select new
                           {
                               ID = artikl.ID,
                               Naziv = artikl.naziv,
                               Kolicina = stavka.kolicina
                           };
                return upit.ToList();
            }
        }

        //ukoliko se odaberu nezaprimljene narudzbenice, argument u metodi osvjezi je 0
        //ukoliko se odaberu zaprimljene narudzbenice, argument u metodi osvjezi je 1 te se skrivaju buttoni za dohvaćanje i brisanje jer nema smisla izbrisati zaprimljenu
        private void cbFilterNarudzbenice_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilterNarudzbenice.SelectedIndex)
            {
                case 0:
                    button1.Visible = true;
                    button2.Visible = true;
                    dgvNarudzbenice.DataSource = null;
                    Osvjezi(0);
                    break;
                case 1:
                    button1.Visible = false;
                    button2.Visible = false;
                    dgvNarudzbenice.DataSource = null;
                    Osvjezi(1);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvNarudzbenice.Rows.Count != 0)
            {
                var id = dgvNarudzbenice.CurrentRow.Cells[0].Value;
                Zaprimi(id);
                Osvjezi(0);
                MessageBox.Show("Roba uspješno zaprimljena!");
                    
            }
        }

        //dohvacaju se stavke i artikli u narudzbenici te se svakom zaprimljenom artiklu poveća odgovarajuća količina i ažurira se količina na zalihi
        //datum zaprimanja narudzbenice automatski se postavlja na trenutno vrijeme
        private void Zaprimi(object id)
        {
                using (var context=new FunctionBarDB())
            {
                var dohvatiArtikl = from artikl in context.artikls
                           join stavke in context.stavka_narudzbe on artikl.ID equals stavke.id_artikl
                           where stavke.id_narudzbenica == (int)id
                           select artikl;

                var dohvatiIdStavke = from artikl in context.artikls
                                      join stavke in context.stavka_narudzbe on artikl.ID equals stavke.id_artikl
                                      where stavke.id_narudzbenica == (int)id
                                      select new
                                      {
                                          Stavka = stavke.kolicina,
                                          ArtiklId = artikl.ID
                                      };
                foreach(artikl artikl in dohvatiArtikl)
                {
                    foreach(var item in dohvatiIdStavke)
                    {
                        if (artikl.ID == item.ArtiklId)
                        {
                            artikl.kolicina_na_zalihi += item.Stavka;
                        }
                    }
                }

                var dohvatiNarudzbenicu = from narudzbenica in context.narudzbenicas
                                          where narudzbenica.ID == (int)id
                                          select narudzbenica;
                var obj = dohvatiNarudzbenicu.SingleOrDefault();
                obj.datum_zaprimanja = DateTime.Today;
                context.SaveChanges();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvNarudzbenice.Rows.Count != 0)
            {
                var id = dgvNarudzbenice.CurrentRow.Cells[0].Value;
                Obrisi(id);
                Osvjezi(0);
            }
        }

        //s obzirom koja narudžbenica je odabrana, ista se briše
        private void Obrisi(object id)
        {
            using (var context = new FunctionBarDB())
            {
                var upit = from n in context.narudzbenicas
                           where n.ID == (int)id
                           select n;
                var obj = upit.SingleOrDefault();
                context.narudzbenicas.Remove(obj);
                context.SaveChanges();
            }
        }

        private void ZaprimanjeRobe_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string helpPoveznica = "FunctionBarHelp.chm";
            Help.ShowHelp(this, Environment.CurrentDirectory + "\\Resources\\" + helpPoveznica, HelpNavigator.Topic, "start.htm#_Toc43663415");
        }
    }
}
