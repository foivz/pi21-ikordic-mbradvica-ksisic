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
namespace FunctionBar
{
    public partial class UnesiZaposlenikaForm : Form
    {
        public UnesiZaposlenikaForm()
        {
            InitializeComponent();
        }





        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new FunctionBarDB())
            {
                long OIB = long.Parse(txtOIB.Text);
                string ime = txtIme.Text;
                string prezime = txtPrezime.Text;
                string adresa = txtAdresa.Text;
                string sprema = txtSprema.Text;
                string korime = txtKorime.Text;
                string lozinka = txtLozinka.Text;
                vrsta_uloge vrsta = cbUloga.SelectedItem as vrsta_uloge;
                context.vrsta_uloge.Attach(vrsta);
                zaposlenik zaposlenik = new zaposlenik
                {
                    OIB = OIB,
                    ime = ime,
                    prezime = prezime,
                    datum_rodenja = dtDatum.Value,
                    adresa = adresa,
                    korisnicko_ime = korime,
                    lozinka = lozinka,
                    vrsta_uloge = vrsta,
                    strucna_sprema = sprema
                };
                context.zaposleniks.Add(zaposlenik);
                context.SaveChanges();
            }
            this.Close();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnesiZaposlenikaForm_Load(object sender, EventArgs e)
        {
            UcitajUloge();
        }

        private void UcitajUloge()
        {
            List<vrsta_uloge> vrste;
            using (var context = new FunctionBarDB())
            {
                vrste = context.vrsta_uloge.ToList();

                cbUloga.DataSource = vrste;
            }
        }
    }
}
