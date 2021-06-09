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
    public partial class UnesiRezervacijuForm : Form
    {
        public UnesiRezervacijuForm()
        {
            InitializeComponent();
        }

        private void UnesiRezervacijuForm_Load(object sender, EventArgs e)
        {
            PopuniStolove();
        }

        private void PopuniStolove()
        {
            List<stol> stolovi;
            using (var context = new FunctionBarDB())
            {
                stolovi = context.stols.ToList();


            }
            cbStol.DataSource = stolovi;
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
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
                    rezervacija novaRezervacija = new rezervacija
                    {
                        Ime = ime,
                        Prezime = prezime,
                        Kontakt = kontakt,
                        datum_rezervacije = dtPicker.Value,
                        datum_zaprimanja = DateTime.Now,
                        stol = stol,
                        id_zaposlenik = UpravljanjeRačunima.VratiTrenutniOIB()
                    };
                    context.rezervacijas.Add(novaRezervacija);
                    context.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Molimo unesite ispravne podatke!");
                }
         
            }
            this.Close();
        }
    }
}
