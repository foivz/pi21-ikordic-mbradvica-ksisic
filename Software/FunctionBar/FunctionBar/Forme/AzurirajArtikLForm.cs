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
    public partial class AzurirajArtikLForm : Form
    {
        private artikl odabranArtikl;
        public AzurirajArtikLForm(artikl artikl)
        {
            InitializeComponent();
            odabranArtikl = artikl;
        }

        private void AzurirajArtikLForm_Load(object sender, EventArgs e)
        {
            UcitajStope();
            UcitajVrste();
            UcitajPodatke();
        }

        private void UcitajStope()
        {
            List<stopa_poreza> stope;
            using (var context = new FunctionBarDB())
            {
                stope = context.stopa_poreza.ToList();
            }
            cbStopaPoreza.DataSource = stope;

            for (int i = 0; i < cbStopaPoreza.Items.Count; i++)
            {
                if ((cbStopaPoreza.Items[i] as stopa_poreza).ID == odabranArtikl.id_stopa_poreza)
                {
                    cbStopaPoreza.SelectedIndex = i;
                    break;
                }
            }
        }

        private void UcitajVrste()
        {
            List<vrsta_artikla> vrsteArtikala;
            using (var context = new FunctionBarDB())
            {
                vrsteArtikala = context.vrsta_artikla.ToList();
            }
            cbVrstaArtikla.DataSource = vrsteArtikala;

            for (int i = 0; i < cbVrstaArtikla.Items.Count; i++)
            {
                if ((cbVrstaArtikla.Items[i] as vrsta_artikla).ID == odabranArtikl.id_vrsta_artikla)
                {
                    cbVrstaArtikla.SelectedIndex = i;
                    break;
                }
            }
        }

        private void UcitajPodatke()
        {
            txtNaziv.Text = odabranArtikl.naziv;
            txtCijena.Text = odabranArtikl.cijena.ToString();
            txtKoličina.Text = odabranArtikl.kolicina_na_zalihi.ToString();
            txtNormativ.Text = Convert.ToString(double.Parse(odabranArtikl.normativ.ToString()));
            txtNabavnaCijena.Text= Convert.ToString(double.Parse(odabranArtikl.nabavna_cijena.ToString()));
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context=new FunctionBarDB())
            {
                string naziv = txtNaziv.Text;
                int cijena = int.Parse(txtCijena.Text);
                float normativ = float.Parse(txtNormativ.Text);
                float kolicina = float.Parse(txtKoličina.Text);
                float nabavna = float.Parse(txtNabavnaCijena.Text);
                vrsta_artikla vrsta = cbVrstaArtikla.SelectedItem as vrsta_artikla;
                /* context.vrsta_artikla.Attach(vrsta);
                stopa_poreza stopa = cbStopaPoreza.SelectedItem as stopa_poreza;
                context.stopa_poreza.Attach(stopa);
                context.artikls.Attach(odabranArtikl);
                */
                odabranArtikl.naziv = naziv;
                odabranArtikl.cijena = cijena;
                odabranArtikl.normativ = normativ;
                odabranArtikl.kolicina_na_zalihi = kolicina;
                odabranArtikl.nabavna_cijena = nabavna;
              /*  odabranArtikl.vrsta_artikla = vrsta;
                odabranArtikl.stopa_poreza = stopa;
              */
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
