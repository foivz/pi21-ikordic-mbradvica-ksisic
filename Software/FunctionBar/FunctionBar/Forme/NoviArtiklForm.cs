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
    public partial class NoviArtiklForm : Form
    {
        public NoviArtiklForm()
        {
            InitializeComponent();
        }
        
        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NoviArtiklForm_Load(object sender, EventArgs e)
        {
            UcitajVrste();
            UcitajStope();
        }

        private void UcitajVrste()
        {
            List<vrsta_artikla> vrsteArtikala;
            using(var context=new FunctionBarDB())
            {
                vrsteArtikala = context.vrsta_artikla.ToList();
          

            }
            cbVrstaArtikla.DataSource = vrsteArtikala;
        }

        private void UcitajStope()
        {
            List<stopa_poreza> stopePoreza;
            using (var context = new FunctionBarDB())
            {
                stopePoreza = context.stopa_poreza.ToList();
            }
            cbStopaPoreza.DataSource = stopePoreza;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var context = new FunctionBarDB())
            {
                try
                {
                    string naziv = txtNaziv.Text;
                    int cijena = int.Parse(txtCijena.Text);
                    float normativ = float.Parse(txtNormativ.Text);
                    float kolicina = float.Parse(txtKoličina.Text);
                    float nabavna = float.Parse(txtNabavnaCijena.Text);
                    vrsta_artikla vrsta = cbVrstaArtikla.SelectedItem as vrsta_artikla;
                    context.vrsta_artikla.Attach(vrsta);
                    stopa_poreza stope = cbStopaPoreza.SelectedItem as stopa_poreza;
                    context.stopa_poreza.Attach(stope);
                    artikl artikl = new artikl
                    {
                        naziv = naziv,
                        cijena = cijena,
                        normativ = normativ,
                        kolicina_na_zalihi = kolicina,
                        nabavna_cijena = nabavna,
                        stopa_poreza = stope,
                        vrsta_artikla = vrsta
                    };
                    context.artikls.Add(artikl);
                    context.SaveChanges();
                }
                catch
                    {
                    MessageBox.Show("Molimo unesite ispravne vrijednosti!");
                }
      
            }
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NoviArtiklForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string helpPoveznica = "FunctionBarHelp.chm";
            Help.ShowHelp(this, Environment.CurrentDirectory + "\\Resources\\" + helpPoveznica, HelpNavigator.Topic, "start.htm#_Toc43663404");
        }
    }
}
