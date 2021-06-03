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
            UcitajPodatke();
        }



        private void UcitajVrste()
        {
            List<vrsta_artikla> vrsteArtikala;
            int idVrste;
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
                    idVrste = odabranArtikl.id_vrsta_artikla;
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
                try
                {
                    string naziv = txtNaziv.Text;
                    int cijena = int.Parse(txtCijena.Text);
                    float normativ = float.Parse(txtNormativ.Text);
                    float kolicina = float.Parse(txtKoličina.Text);
                    float nabavna = float.Parse(txtNabavnaCijena.Text);
                    /*  vrsta_artikla vrsta = cbVrstaArtikla.SelectedItem as vrsta_artikla;
                      context.vrsta_artikla.Attach(vrsta);
                    */
                    context.artikls.Attach(odabranArtikl);
                    odabranArtikl.naziv = naziv;
                    odabranArtikl.cijena = cijena;
                    odabranArtikl.normativ = normativ;
                    odabranArtikl.kolicina_na_zalihi = kolicina;
                    odabranArtikl.nabavna_cijena = nabavna;
                    context.SaveChanges();
                }
               catch(Exception ex)
                {
                    MessageBox.Show("Molim unesite ispravne vrijednosti");
                }
            }
            this.Close();
        }
    }
}
