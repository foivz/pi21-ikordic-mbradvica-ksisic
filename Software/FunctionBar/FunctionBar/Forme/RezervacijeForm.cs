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
    public partial class RezervacijeForm : Form
    {
        public RezervacijeForm()
        {
            InitializeComponent();
        }

        private void RezervacijeForm_Load(object sender, EventArgs e)
        {
            
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvRezervacije.DataSource = null;
            dgvRezervacije.DataSource = Rezervacije();
        
            //UcitajRezervacije();
        }

        private object Rezervacije()
        {
            using (var context=new FunctionBarDB())
            {
                return context.rezervacijas.ToList();
            }
        }

        private void UcitajRezervacije()
        {
            using (var context = new FunctionBarDB())
            {
                var query = from r in context.rezervacijas
                            join zaposlenik in context.zaposleniks on r.id_zaposlenik equals zaposlenik.OIB
                            join stol in context.stols on r.id_stol equals stol.ID
                            join vrsta_stola in context.vrsta_stola on stol.id_vrsta_stola equals vrsta_stola.ID
                            select new
                            {
                                Rezervacija = r.ID,
                                id_zaposlenik=r.id_zaposlenik,
                                Datum_zaprimanja = r.datum_zaprimanja,
                                Rezervirano_za = r.datum_rezervacije,
                                Ime=r.Ime,
                                Prezime=r.Prezime,
                                Kontakt=r.Kontakt,
                                Stol = stol.ID,
                                VrstaStola = vrsta_stola.naziv
                            };
                dgvRezervacije.DataSource = query.ToList();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IzbrisiRezervaciju();
        }

        private void IzbrisiRezervaciju()
        {
            var idRezervacije = dgvRezervacije.CurrentRow.Cells[0].Value;
            using (var context=new FunctionBarDB())
            {
                var query = from rezervacija in context.rezervacijas
                            where rezervacija.ID == (int)idRezervacije
                            select rezervacija;
                foreach(rezervacija item in query)
                {
                    context.rezervacijas.Remove(item);
                }
                context.SaveChanges();

            }
            Osvjezi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UnesiRezervacijuForm forma = new UnesiRezervacijuForm();
            forma.ShowDialog();
            Osvjezi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rezervacija rezervacija = dgvRezervacije.CurrentRow.DataBoundItem     as rezervacija;
            AzurirajRezervaciju forma = new AzurirajRezervaciju(rezervacija);
            forma.ShowDialog();
            Osvjezi();
        }

        private void dgvRezervacije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RezervacijeForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string helpPoveznica = "FunctionBarHelp.chm";
            Help.ShowHelp(this, Environment.CurrentDirectory + "\\Resources\\" + helpPoveznica, HelpNavigator.Topic, "start.htm#_Toc43663411");
        }
    }
}
