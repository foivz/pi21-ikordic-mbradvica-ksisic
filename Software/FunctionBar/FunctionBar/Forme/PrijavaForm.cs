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
    public partial class PrijavaForm : Form
    {
        public PrijavaForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {

            UpravljanjeRačunima.ProvjeriUnose(txtKorime.Text, txtLozinka.Text);
            if (UpravljanjeRačunima.ispravno) {
                GlavnaForma forma = new GlavnaForma();
                forma.ShowDialog();
                this.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Neispravno uneseni korisnički podaci!");
            }
           



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void PrijavaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
