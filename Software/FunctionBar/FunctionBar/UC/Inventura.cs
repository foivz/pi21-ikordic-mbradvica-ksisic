using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionBarDb;
using FunctionBar.Forme;

namespace FunctionBar.UC
{
    public partial class Inventura : UserControl
    {
        private List<artikl> _artikli = null;
        private InventuraForm forma = null;
        public Inventura(List <artikl> artikli, InventuraForm inventuraForm)
        {
            _artikli = artikli;
            forma = inventuraForm;
            InitializeComponent();
        }

        //dohvaćanje artikala i onemogućavanje editiranja textboxa
        private void Inventura_Load(object sender, EventArgs e)
        {
            DohvatiArtikle();
            uxKolicinaUSustavu.ReadOnly = true;
            uxRazlika.ReadOnly = true;
            uxStanjeNaSkladistu.ReadOnly = true;

        }


        //dohvaćanje naziva artikala i spremanje u combobox
        private void DohvatiArtikle()
        {
            foreach (var item in _artikli.OrderBy(x => x.naziv))
            {
                uxNaziv.Items.Add(item.naziv);
            }
        }

        //metoda koja služi za provjeru upisanog stanja na skladištu
        //ukoliko je stanje upisano, vraća se razlika stanja u sustavu i stvarnog stanja nakon provođenja inventure
        public  double Razlika(string kolicinaUSustavu, string stanjeNaSkladistu)
        {
            stanjeNaSkladistu = stanjeNaSkladistu.Replace(".", ",");
            double razlika;
            if (stanjeNaSkladistu != "")
            {
                razlika = double.Parse(kolicinaUSustavu) - double.Parse(stanjeNaSkladistu);
                return razlika;
            }
            else
                return 0;

        }


        //kolicina artikla na temelju odabranog artikla
        private double? kolicinaArtikla(string naziv)
        {
            double? kolicina=_artikli.First(x=>x.naziv==naziv).kolicina_na_zalihi;
            return kolicina;
        }
        private void uxStanjeNaSkladistu_TextChanged(object sender, EventArgs e)
        {
            double razlika = 0;
            try
            {
                razlika = Razlika(uxKolicinaUSustavu.Text, uxStanjeNaSkladistu.Text);
            }
            catch
            {
                MessageBox.Show("Unešena vrijednost mora biti broj");
                uxRazlika.Text = "0";
                uxStanjeNaSkladistu.Clear();
            }

            if (uxStanjeNaSkladistu.Text != "")
            {
                uxStanjeNaSkladistu.BackColor = SystemColors.Window;
                if (razlika > 0)
                {
                    uxRazlika.Text = razlika.ToString();
                    uxRazlika.BackColor = System.Drawing.Color.Crimson;
                }
                else if (razlika < 0)
                {
                    uxRazlika.Text = Math.Abs(razlika).ToString();
                    uxRazlika.BackColor = System.Drawing.Color.Crimson;
                }
                else
                {
                    uxRazlika.Text = razlika.ToString();
                    uxRazlika.BackColor = System.Drawing.Color.LimeGreen;
                }
            }
            else
            {
                uxRazlika.BackColor = SystemColors.Control;
                uxStanjeNaSkladistu.BackColor = System.Drawing.Color.AntiqueWhite;
            }
        }

        private void uxNaziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxStanjeNaSkladistu.Text = "";
            uxRazlika.Text = "0";
            double? kolicina = kolicinaArtikla(uxNaziv.Text);
            uxKolicinaUSustavu.Text = kolicina.ToString();
            uxStanjeNaSkladistu.ReadOnly = false;
            uxStanjeNaSkladistu.BackColor = System.Drawing.Color.AntiqueWhite;
        }


        //korisnik dobiva podatke o podudarnosti količine artikla u sustavu i u stvarnosti (na skaldištu)
        private void uxRazlika_MouseClick(object sender, MouseEventArgs e)
        {
            double razlika =Razlika(uxKolicinaUSustavu.Text, uxStanjeNaSkladistu.Text);
            if (razlika > 0)
            {
                MessageBox.Show("Količina artikla " + uxNaziv.Text + " u sustavu se ne podudara sa količinom u skladištu." + Environment.NewLine + "U sustavu je " + razlika + " artikla više nego u skladištu. ");

            }

            if (razlika < 0)
            {
                MessageBox.Show("Količina artikla " + uxNaziv.Text + " u sustavu se ne podudara sa količinom u skladištu." + Environment.NewLine + "U sustavu je " + Math.Abs(razlika) + " artikla manje nego u skladištu. ");
            }

            if (razlika == 0)
            {
                MessageBox.Show("Količina artikla " + uxNaziv.Text + " u sustavu se podudara sa količinom u skladištu.");
            }
        }

        public  void AzurirajStanje(artikl artikl, double stanje)
        {
            using (var context = new FunctionBarDB())
            {
                context.artikls.Attach(artikl);
                artikl.kolicina_na_zalihi = stanje;
                context.SaveChanges();
            }
        }


        public void AzurirajArtikl()
        {
            artikl artikl = null;
            artikl = _artikli.FirstOrDefault(r => r.naziv == uxNaziv.Text);
            if (artikl == null || uxStanjeNaSkladistu.Text == "") return;
            else
            {
                double kolicina = double.Parse(uxStanjeNaSkladistu.Text.Replace(".", ","));
                AzurirajStanje(artikl, kolicina);
            }
        }

        private void uxIzbrisi_Click(object sender, EventArgs e)
        {
            forma.Izbrisi(this);
        }
    }
}
