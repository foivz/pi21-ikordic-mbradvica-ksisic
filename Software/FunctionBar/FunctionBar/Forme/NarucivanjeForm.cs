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
using FunctionBar.UC;
namespace FunctionBar.Forme
{
    public partial class NarucivanjeForm : Form
    {
        List<artikl> artikli = null;
        public NarucivanjeForm()
        {
            InitializeComponent();
            artikli = UcitajArtikle();
        }

        private List<artikl> UcitajArtikle()
        {
            using (var context=new FunctionBarDB())
            {
                return context.artikls.ToList();
            }
        }

        private void NarucivanjeForm_Load(object sender, EventArgs e)
        {
            SviDobavljaci();
        }

        private void SviDobavljaci()
        {
            List<dobavljac> sviDobavljaci;
            using (var context=new FunctionBarDB())
            {
                sviDobavljaci = context.dobavljacs.ToList();

            }
            cbNaziv.DataSource = sviDobavljaci;
        }

        private void cbNaziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopuniPodatke();
        }

        //pune se podaci o dobavljaču na temelju odabranog u comboBoxu
        private void PopuniPodatke()
        {
            dobavljac dobavljac = cbNaziv.SelectedItem as dobavljac;
            txtOIB.Text = dobavljac.OIB.ToString();
            txtKontakt.Text = dobavljac.telefon.ToString();
            txtIBAN.Text = dobavljac.IBAN.ToString();
            txtAdresa.Text = dobavljac.adresa.ToString();


        }

        private void uxArtikliKoličina_Paint(object sender, PaintEventArgs e)
        {

        }
        public void IzbrisiUC(NaruciArtikl control)
        {
            uxArtikliKoličina.Controls.Remove(control);
            control.Dispose();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            uxArtikliKoličina.Controls.Add(new NaruciArtikl(artikli,this));
        }

        private void btnUkloniSve_Click(object sender, EventArgs e)
        {
            UkloniKontrole();

        }

        //miču se sve kontrole s panela
        private void UkloniKontrole()
        {
            var uc = uxArtikliKoličina.Controls.OfType<NaruciArtikl>().ToList();
            foreach (var item in uc)
            {
                uxArtikliKoličina.Controls.Remove(item);
                item.Dispose();
            }
        }

        private void btnNaruci_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            using (var context=new FunctionBarDB())
            {
                narudzbenica narudzbenica = new narudzbenica
                {
                    datum_narudzbe = DateTime.Today,
                    id_zaposlenik = UpravljanjeRačunima.VratiTrenutniOIB(),
                    id_dobavljac = Convert.ToInt32(txtOIB.Text),
                };
                context.narudzbenicas.Add(narudzbenica);
                context.SaveChanges();
                var idNoveNarudzbenice = narudzbenica.ID;
                try
                {
                    foreach(NaruciArtikl item in uxArtikliKoličina.Controls)
                    {
                        brojac++;
                        string nazivArtikla = item.IdArtikla();
                        var query = from artikl in context.artikls.Where(x => x.naziv.StartsWith(nazivArtikla) && x.naziv.EndsWith(nazivArtikla))
                                    select artikl;
                        var obj = query.FirstOrDefault();

                        stavka_narudzbe stavke = new stavka_narudzbe
                        {
                            id_narudzbenica = idNoveNarudzbenice,
                            id_artikl = obj.ID,
                            kolicina = item.KolicinaArtikla()
                        };
                        context.stavka_narudzbe.Add(stavke);
                    }                                
                    if (brojac == 0)
                    {
                        MessageBox.Show("Unesite barem jedan artikl!");
                    }
                    else
                    {
                         MessageBox.Show("Uspješno naručena roba!");
                        context.SaveChanges();
                    }
                }

                catch 
                {
                    MessageBox.Show("Pogrešan unos narudžbenice!");
                    context.narudzbenicas.Remove(narudzbenica);
                    context.SaveChanges();
                }

            }
            UkloniKontrole();

        }
    }
}
