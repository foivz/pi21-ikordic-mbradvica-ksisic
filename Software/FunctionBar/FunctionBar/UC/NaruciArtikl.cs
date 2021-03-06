using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionBarDb;
using FunctionBar.Forme;

namespace FunctionBar.UC
{
    public partial class NaruciArtikl : UserControl
    {
        private List<artikl> artikliCombo = null;
        private NarucivanjeForm frm = null;
        public NaruciArtikl(List<artikl> artikli, NarucivanjeForm narucivanjeForma)
        {
            artikliCombo = artikli;
            frm = narucivanjeForma;
            InitializeComponent();
        }

        private void NaruciArtikl_Load(object sender, EventArgs e)
        {
            PopuniArtikle();
        }

        private void PopuniArtikle()
        {
           foreach(var item in artikliCombo)
            {
                uxArtikl.Items.Add(item.naziv);
            }
        }

        public string IdArtikla()
        {
            string odabraniArtikl = uxArtikl.Text;
            return odabraniArtikl;
        }
        public int KolicinaArtikla()
        {
            int kolicina = int.Parse(uxKoličina.Text);
            return kolicina;
        }

        private void btnIzbrisi_Click(object sender, EventArgs e)
        {
            frm.IzbrisiUC(this);
        }
    }
}
