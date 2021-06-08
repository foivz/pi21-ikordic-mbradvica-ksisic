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
    public partial class ZaposleniciForm : Form
    {
        public ZaposleniciForm()
        {
            InitializeComponent();
        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {
            Osvjezi();

        }

        private void Osvjezi()
        {
            dgvZaposlenici.DataSource = null;
            dgvZaposlenici.DataSource = UcitajZaposlenike();
        }

        private object UcitajZaposlenike()
        {
            using (var context=new FunctionBarDB())
            {
                return context.zaposleniks.ToList();
            }
        }

        private void btnIzbrisiZaposlenika_Click(object sender, EventArgs e)
        {
            IzbrisiZaposlenog();
        }

        private void IzbrisiZaposlenog()
        {
            zaposlenik zaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as zaposlenik;
            using (var context = new FunctionBarDB())
            {
                context.zaposleniks.Attach(zaposlenik);
                context.zaposleniks.Remove(zaposlenik);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void btnUnesiZaposlenika_Click(object sender, EventArgs e)
        {
            UnesiZaposlenikaForm forma = new UnesiZaposlenikaForm();
            forma.ShowDialog();
            Osvjezi();
        }

        private void btnAzurirajZaposlenika_Click(object sender, EventArgs e)
        {
            zaposlenik zaposlenik = dgvZaposlenici.CurrentRow.DataBoundItem as zaposlenik;
            AzurirajZaposlenikaForm forma = new AzurirajZaposlenikaForm(zaposlenik);
            forma.ShowDialog();
            Osvjezi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
