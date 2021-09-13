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
    public partial class AzurirajZaposlenikaForm : Form
    {
        private zaposlenik odabranZaposlenik;
        public AzurirajZaposlenikaForm(zaposlenik zaposlenik)
        {
            InitializeComponent();
            odabranZaposlenik = zaposlenik;
        }

        private void AzurirajZaposlenikaForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajUloge();
        }

        private void UcitajUloge()
        {
            List<vrsta_uloge> uloge;
            using (var context=new FunctionBarDB())
            {
                uloge = context.vrsta_uloge.ToList();
            }
            cbUloga.DataSource = uloge;
            for (int i = 0; i < cbUloga.Items.Count; i++)
            {
                if ((cbUloga.Items[i] as vrsta_uloge).ID == odabranZaposlenik.id_vrsta_uloge)
                {
                    cbUloga.SelectedIndex = i;
                    break;
                }
            }
        }

        private void UcitajPodatke()
        {
            txtOIB.Text = odabranZaposlenik.OIB.ToString();
            txtIme.Text = odabranZaposlenik.ime;
            txtPrezime.Text = odabranZaposlenik.prezime;
            txtKorime.Text = odabranZaposlenik.korisnicko_ime;
            txtAdresa.Text = odabranZaposlenik.adresa;
            txtSprema.Text = odabranZaposlenik.strucna_sprema;
            txtLozinka.Text = odabranZaposlenik.lozinka;
            dtDatum.Value = (DateTime)odabranZaposlenik.datum_rodenja;
            
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context=new FunctionBarDB())
            {
                try
                {
                    long OIB = long.Parse(txtOIB.Text);
                    string ime = txtIme.Text;
                    string prezime = txtPrezime.Text;
                    string adresa = txtAdresa.Text;
                    string sprema = txtSprema.Text;
                    string korime = txtKorime.Text;
                    string lozinka = txtLozinka.Text;
                    context.zaposleniks.Attach(odabranZaposlenik);
                    odabranZaposlenik.OIB = OIB;
                    odabranZaposlenik.ime = ime;
                    odabranZaposlenik.prezime = prezime;
                    odabranZaposlenik.adresa = adresa;
                    odabranZaposlenik.strucna_sprema = sprema;
                    odabranZaposlenik.korisnicko_ime = korime;
                    odabranZaposlenik.lozinka = lozinka;
                    odabranZaposlenik.datum_rodenja = dtDatum.Value;
                    odabranZaposlenik.id_vrsta_uloge = (cbUloga.SelectedItem as vrsta_uloge).ID;
                    context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Unesite ispravne vrijednosti");
                }
            }
            this.Close();
        }

        private void AzurirajZaposlenikaForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string helpPoveznica = "FunctionBarHelp.chm";
            Help.ShowHelp(this, Environment.CurrentDirectory + "\\Resources\\" + helpPoveznica, HelpNavigator.Topic, "start.htm#_Toc43663409");
        }
    }
}
