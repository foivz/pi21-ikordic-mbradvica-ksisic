using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionBar.Forme;
using FunctionBarDb;
namespace FunctionBar
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            InitializeComponent();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            if (UpravljanjeRačunima.VratiTrenutnuUlogu() == 2)
            {
                uxStatistika.Visible = false;
                uxInventura.Visible = false;
                uxNarucivanje.Visible = false;
                uxZaposlenici.Visible = false;
            }
        }

        private void uxAktivnaForma_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uxArtikl_Click(object sender, EventArgs e)
        {
            uxAktivnaForma.Controls.Clear();
            ArtikliForm aktivnaForma = new ArtikliForm();
            aktivnaForma.TopLevel = false;
            aktivnaForma.AutoScroll = true;
            aktivnaForma.FormBorderStyle = FormBorderStyle.None;
            aktivnaForma.WindowState = FormWindowState.Maximized;
            aktivnaForma.Dock = DockStyle.Fill;
            uxAktivnaForma.Controls.Add(aktivnaForma);
            aktivnaForma.Show();
        }

        private void uxZaposlenici_Click(object sender, EventArgs e)
        {
            uxAktivnaForma.Controls.Clear();
            ZaposleniciForm aktivnaForma = new ZaposleniciForm();
            aktivnaForma.TopLevel = false;
            aktivnaForma.AutoScroll = true;
            aktivnaForma.FormBorderStyle = FormBorderStyle.None;
            aktivnaForma.WindowState = FormWindowState.Maximized;
            aktivnaForma.Dock = DockStyle.Fill;
            uxAktivnaForma.Controls.Add(aktivnaForma);
            aktivnaForma.Show();
        }

    

        private void uxRacuni_Click(object sender, EventArgs e)
        {
            uxAktivnaForma.Controls.Clear();
            RacuniForm aktivnaForma = new RacuniForm();
            aktivnaForma.TopLevel = false;
            aktivnaForma.AutoScroll = true;
            aktivnaForma.FormBorderStyle = FormBorderStyle.None;
            aktivnaForma.WindowState = FormWindowState.Maximized;
            aktivnaForma.Dock = DockStyle.Fill;
            uxAktivnaForma.Controls.Add(aktivnaForma);
            aktivnaForma.Show();
        }

  

      

        private void uxStatistika_Click(object sender, EventArgs e)
        {
            uxAktivnaForma.Controls.Clear();
            StatistikaForm aktivnaForma = new StatistikaForm();
            aktivnaForma.TopLevel = false;
            aktivnaForma.AutoScroll = true;
            aktivnaForma.FormBorderStyle = FormBorderStyle.None;
            aktivnaForma.WindowState = FormWindowState.Maximized;
            aktivnaForma.Dock = DockStyle.Fill;
            uxAktivnaForma.Controls.Add(aktivnaForma);
            aktivnaForma.Show();
        }

        private void uxNarucivanje_Click_1(object sender, EventArgs e)
        {
                uxAktivnaForma.Controls.Clear();
                NarucivanjeForm aktivnaForma = new NarucivanjeForm();
                aktivnaForma.TopLevel = false;
                aktivnaForma.AutoScroll = true;
                aktivnaForma.FormBorderStyle = FormBorderStyle.None;
                aktivnaForma.WindowState = FormWindowState.Maximized;
                aktivnaForma.Dock = DockStyle.Fill;
                uxAktivnaForma.Controls.Add(aktivnaForma);
                aktivnaForma.Show();
            
        }

        private void uxInventura_Click_1(object sender, EventArgs e)
        {
            uxAktivnaForma.Controls.Clear();
            InventuraForm aktivnaForma = new InventuraForm();
            aktivnaForma.TopLevel = false;
            aktivnaForma.AutoScroll = true;
            aktivnaForma.FormBorderStyle = FormBorderStyle.None;
            aktivnaForma.WindowState = FormWindowState.Maximized;
            aktivnaForma.Dock = DockStyle.Fill;
            uxAktivnaForma.Controls.Add(aktivnaForma);
            aktivnaForma.Show();
        }

        private void uxZaprimanjeRobe_Click_1(object sender, EventArgs e)
        {
            uxAktivnaForma.Controls.Clear();
            ZaprimanjeRobe aktivnaForma = new ZaprimanjeRobe();
            aktivnaForma.TopLevel = false;
            aktivnaForma.AutoScroll = true;
            aktivnaForma.FormBorderStyle = FormBorderStyle.None;
            aktivnaForma.WindowState = FormWindowState.Maximized;
            aktivnaForma.Dock = DockStyle.Fill;
            uxAktivnaForma.Controls.Add(aktivnaForma);
            aktivnaForma.Show();
        }

        private void uxRezervacije_Click_1(object sender, EventArgs e)
        {
            uxAktivnaForma.Controls.Clear();
            RezervacijeForm aktivnaForma = new RezervacijeForm();
            aktivnaForma.TopLevel = false;
            aktivnaForma.AutoScroll = true;
            aktivnaForma.FormBorderStyle = FormBorderStyle.None;
            aktivnaForma.WindowState = FormWindowState.Maximized;
            aktivnaForma.Dock = DockStyle.Fill;
            uxAktivnaForma.Controls.Add(aktivnaForma);
            aktivnaForma.Show();
        }

        private void uxAktivnaForma_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            string helpPoveznica = "FunctionBarHelp.chm";
            Help.ShowHelp(this, Environment.CurrentDirectory + "\\Resources\\" + helpPoveznica, HelpNavigator.Topic, "start.htm#_Toc43663402");
        }
    }
}
