using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using FunctionBarDb;
using System.Data.Entity;

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
            UcitajVrste();
            UcitajPorez();
            UcitajPodatke();
        }

        private void UcitajPorez()
        {
            List<stopa_poreza> stopa;
            using (var context = new FunctionBarDB())
            {
                stopa = context.stopa_poreza.ToList();
            }
            cbPorez.DataSource = stopa;

            for (int i = 0; i < cbPorez.Items.Count; i++)
            {
                if ((cbPorez.Items[i] as stopa_poreza).ID == odabranArtikl.id_stopa_poreza)
                {
                    cbPorez.SelectedIndex = i;
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

                try {
                    string naziv = txtNaziv.Text;
                    int cijena = int.Parse(txtCijena.Text);
                    float normativ = float.Parse(txtNormativ.Text);
                    float kolicina = float.Parse(txtKoličina.Text);
                    float nabavna = float.Parse(txtNabavnaCijena.Text);                          
                    context.artikls.Attach(odabranArtikl);
                    odabranArtikl.naziv = naziv;
                    odabranArtikl.cijena = cijena;
                    odabranArtikl.normativ = normativ;
                    odabranArtikl.kolicina_na_zalihi = kolicina;
                    odabranArtikl.nabavna_cijena = nabavna;
                    odabranArtikl.id_vrsta_artikla = (cbVrstaArtikla.SelectedItem as vrsta_artikla).ID;
                    odabranArtikl.id_stopa_poreza = (cbPorez.SelectedItem as stopa_poreza).ID;
                    context.SaveChanges();
                }

                catch
                {
                MessageBox.Show("Molimo unesite ispravne vrijednosti!");
                }
            
            }
            this.Close();
        }

        private void AzurirajArtikLForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string helpPoveznica = "FunctionBarHelp.chm";
            Help.ShowHelp(this, Environment.CurrentDirectory + "\\Resources\\" + helpPoveznica, HelpNavigator.Topic, "start.htm#_Toc43663405");
        }
    }
}
