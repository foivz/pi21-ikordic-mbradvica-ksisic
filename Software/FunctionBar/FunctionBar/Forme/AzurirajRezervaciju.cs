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
    public partial class AzurirajRezervaciju : Form
    {
        private rezervacija odabranaRezervacija;
        public AzurirajRezervaciju(rezervacija rezervacija)
        {
            InitializeComponent();
            odabranaRezervacija = rezervacija;
        }

        private void AzurirajRezervaciju_Load(object sender, EventArgs e)
        {
            UcitajStolove();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            txtIme.Text = odabranaRezervacija.Ime;
            txtPrezime.Text = odabranaRezervacija.Prezime;
            txtKontakt.Text = odabranaRezervacija.Kontakt;
            dtPicker.Value = odabranaRezervacija.datum_rezervacije;

                
        }

        private void UcitajStolove()
        {
            List<stol> stol;
            using (var context = new FunctionBarDB())
            {
                stol = context.stols.ToList();
            }
            cbStol.DataSource = stol;

            for (int i = 0; i < cbStol.Items.Count; i++)
            {
                if ((cbStol.Items[i] as stol).ID == odabranaRezervacija.id_stol)
                {
                    cbStol.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context=new FunctionBarDB())
            {
                try
                {
                    string ime = txtIme.Text;
                    string prezime = txtPrezime.Text;
                    string kontakt = txtKontakt.Text;
                    stol stol = cbStol.SelectedItem as stol;
                   context.stols.Attach(stol);
                    context.rezervacijas.Attach(odabranaRezervacija);
                    odabranaRezervacija.Ime = ime;
                    odabranaRezervacija.Prezime = prezime;
                    odabranaRezervacija.Kontakt = kontakt;
                    odabranaRezervacija.datum_rezervacije = dtPicker.Value;
                    odabranaRezervacija.stol = stol;
                    context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Pogrešan unos, molimo ponovite!");
                }
            }
            this.Close();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AzurirajRezervaciju_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string helpPoveznica = "FunctionBarHelp.chm";
            Help.ShowHelp(this, Environment.CurrentDirectory + "\\Resources\\" + helpPoveznica, HelpNavigator.Topic, "start.htm#_Toc43663412");
        }
    }
}
