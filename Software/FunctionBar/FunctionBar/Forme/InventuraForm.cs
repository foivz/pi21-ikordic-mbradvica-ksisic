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
    public partial class InventuraForm : Form
    {
        List<artikl> artikli = null;
        public InventuraForm()
        {
            InitializeComponent();
            artikli = SviArtikli();

            /*List<zaposlenik> zaposlenici = new List<zaposlenik>();
            List<String> oibImeZaposlenika = new List<string>();
            using (var context = new FunctionBarDB())
            {
                
                zaposlenici = context.zaposleniks.ToList();
                foreach (var zap in zaposlenici) {
                    oibImeZaposlenika.Add(zap.ime + " " + zap.prezime + ", " + zap.OIB.ToString());
                }

            }
            cbZaposlenik.DataSource = oibImeZaposlenika;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Osvjezi();
        }
        public List<artikl> SviArtikli()
        {
            using (var context=new FunctionBarDB())
            {
                return context.artikls.ToList();
            }
        }


        //dodavanje novih polja u panel
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            uxArtikli.Controls.Add(new Inventura(artikli,this));

        }
        //ukoliko se klikne na uxArtikli panel, miče se fokus iz textboxa
        private void uxArtikli_MouseDown(object sender, MouseEventArgs e)
        {
            uxArtikli.Focus();
        }

        private void uxArtikli_Click(object sender, EventArgs e)
        {
  
        }

        //miče sve kontrole klikom na gumb "Izbrisi sve"
        private void Osvjezi()
        {
            var uc = uxArtikli.Controls.OfType<Inventura>().ToList();
            foreach (var item in uc)
            {
                uxArtikli.Controls.Remove(item);
                item.Dispose();
            }
        }

        //brise jednu kontrolu (klikom na crveni gumb x)
        public void Izbrisi(Inventura odabranaKontrola)
        {
            uxArtikli.Controls.Remove(odabranaKontrola);
            odabranaKontrola.Dispose();

        }


        //upozorava korisnika ukoliko nije odabran nijedan artikl iz comboboxa
        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Želite li ažurirati artikle?", "Ažuriranje", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                int brojac = 0;
                int idInventure = 0;
                foreach (Inventura item in uxArtikli.Controls)
                {
                    brojac++;
                    if (brojac == 1) {
                        using (var context = new FunctionBarDB())
                        {

                            try
                            {
                                //String[] imeOib = cbZaposlenik.SelectedItem.ToString().Split(' ');
                                inventura inventura = new inventura
                                {
                                    ID = context.inventuras.Count(),
                                    datum_inventure = DateTime.Now,
                                    OIB = UpravljanjeRačunima.VratiTrenutniOIB()
                                    //OIB = long.Parse(imeOib[imeOib.Length - 1])

                                };
                                idInventure = inventura.ID;
                                context.inventuras.Add(inventura);
                                context.SaveChanges();
                            }
                            catch
                            {
                                MessageBox.Show("Nije se azuriralo");
                            }
                        }
                        }
                    item.AzurirajArtikl(idInventure);
                    
                }

                if (brojac > 0)
                {
                    Osvjezi();
                    MessageBox.Show("Ažurirano!");
                }
                else
                    MessageBox.Show("Niste dodali ni jedan artikl!");

            }
            else if (dialog == DialogResult.No)
            {

            }
        }

        private void InventuraForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string helpPoveznica = "FunctionBarHelp.chm";
            Help.ShowHelp(this, Environment.CurrentDirectory + "\\Resources\\" + helpPoveznica, HelpNavigator.Topic, "start.htm#_Toc43663414");
        }
    }
}
