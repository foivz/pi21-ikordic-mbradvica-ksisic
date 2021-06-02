﻿using System;
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
    public partial class ArtikliForm : Form
    {
        public ArtikliForm()
        {
            InitializeComponent();
        }

        private void ArtikliForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvVrstaArtikla.DataSource = null;
            dgvVrstaArtikla.RowTemplate.Height = 100;
            dgvVrstaArtikla.DataSource = UzmiVrstuArtikla();
            
        }

        private object UzmiVrstuArtikla()
        {
            using (var context = new FunctionBarDB())
            {
                slika.ImageLayout= DataGridViewImageCellLayout.Stretch;
               
                return context.vrsta_artikla.ToList();
            }
        }
        private object UzmiArtikle(vrsta_artikla vrstaArtikla)
        {
            using (var context = new FunctionBarDB())
            {
                context.vrsta_artikla.Attach(vrstaArtikla);
                return vrstaArtikla.artikls.ToList();
            }
        }

        private void dgvVrstaArtikla_SelectionChanged(object sender, EventArgs e)
        {
            vrsta_artikla odabranaVrsta = dgvVrstaArtikla.CurrentRow.DataBoundItem as vrsta_artikla;
            dgvArtikl.DataSource = UzmiArtikle(odabranaVrsta);
        }

        private void btnUnesiArtikl_Click(object sender, EventArgs e)
        {
            NoviArtiklForm forma = new NoviArtiklForm();
            forma.ShowDialog();
            Osvjezi();
        }

        private void btnIzbrisiArtikl_Click(object sender, EventArgs e)
        {
            IzbrisiArtikl();
        }

        private void IzbrisiArtikl()
        {
            artikl artikl = dgvArtikl.CurrentRow.DataBoundItem as artikl;
            using(var context= new FunctionBarDB())
            {
                context.artikls.Attach(artikl);
                context.artikls.Remove(artikl);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void btnAzurirajArtikl_Click(object sender, EventArgs e)
        {
            OtvoriAžurirajArtikl();
        }

        private void OtvoriAžurirajArtikl()
        {
            artikl artikl = dgvArtikl.CurrentRow.DataBoundItem as artikl;
            AzurirajArtikLForm forma = new AzurirajArtikLForm(artikl);
            forma.ShowDialog();
            Osvjezi();
            
        }
    }
}
