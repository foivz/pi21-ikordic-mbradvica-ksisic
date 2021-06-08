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
            using (var context=new FunctionBarDB())
            {
                var query = from artikl in context.artikls
                            join vrsta in context.vrsta_artikla on artikl.id_vrsta_artikla equals vrsta.ID
                            where artikl.id_vrsta_artikla ==(int)odabranaVrsta.ID && (artikl.aktivan==true || artikl.aktivan==null)
                            select artikl;
                    dgvArtikl.DataSource = query.ToList();
            }
           
          
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
                var query = context.artikls.SingleOrDefault(x => x.ID == artikl.ID);
                if (query != null)
                {
                    query.aktivan = false;
                    context.SaveChanges();
                }
               // context.artikls.Remove(artikl);
               
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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            labelKolicina.Text = (int.Parse(labelKolicina.Text) + 1).ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ProvjeriMinus();
            labelKolicina.Text = (int.Parse(labelKolicina.Text) -1).ToString();
        }

        private void ProvjeriMinus()
        {
            if (int.Parse(labelKolicina.Text) <= 0)
            {
                labelKolicina.Text = "1";
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ArtikliZaRacun();
            handleKolicina();
            PostaviLabeluNaJedan();
            Iznos();
            UkupnaSuma();
        }

        private void Iznos()
        {
           foreach(DataGridViewRow red in dgvZaKucanje.Rows)
            {
                red.Cells[dgvZaKucanje.Columns["Iznos"].Index].Value = (Convert.ToDouble(red.Cells[dgvZaKucanje.Columns["Cijena"].Index].Value) * Convert.ToDouble(red.Cells[dgvZaKucanje.Columns["Količina"].Index].Value));
                    
            }
        }

        private void UkupnaSuma()
        {
            txtSuma.Text = "0";
            foreach (DataGridViewRow red in dgvZaKucanje.Rows)
            {
                int indeks = red.Index;
                txtSuma.Text = (Double.Parse(txtSuma.Text.ToString()) + Double.Parse(dgvZaKucanje.Rows[indeks].Cells[4].Value.ToString())).ToString();
            }
        }

        private void PostaviLabeluNaJedan()
        {
            labelKolicina.Text = "1";
        }

        private void ArtikliZaRacun()
        {
            dgvZaKucanje.ColumnCount = 5;
            dgvZaKucanje.Columns[0].Name = "ID";
            dgvZaKucanje.Columns[0].Visible = false;
            dgvZaKucanje.Columns[1].Name = "Artikl";
            dgvZaKucanje.Columns[2].Name = "Cijena";
            dgvZaKucanje.Columns[3].Name = "Količina";
            dgvZaKucanje.Columns[4].Name = "Iznos";

            artikl artiklZaKucanje = dgvArtikl.CurrentRow.DataBoundItem as artikl;
            string[] dodajRed = new String[] { artiklZaKucanje.ID.ToString(), artiklZaKucanje.naziv, artiklZaKucanje.cijena.ToString(), "1" };
            dgvZaKucanje.Rows.Add(dodajRed);        
        }

        private void handleKolicina()
        {
            int red = 0;
            red = dgvZaKucanje.Rows.Count - 2;
            if (Convert.ToInt32(labelKolicina.Text) > 0)
            {
                dgvZaKucanje["Količina", red].Value = labelKolicina.Text;
            }
            else
            {
                MessageBox.Show("Unesite ispravnu količinu artikla!");
            }
        }

        private void btnUkloniArtikl_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvZaKucanje.CurrentCell.RowIndex;
                if(index > -1)
                {
                    dgvZaKucanje.Rows.RemoveAt(index);
                    dgvZaKucanje.Refresh();
                    UkupnaSuma();
                } 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške!");
            }
        }

        private void btnIspisiRacun_Click(object sender, EventArgs e)
        {
            using (var context=new FunctionBarDB())
            {
                racun racun = new racun
                {
                    datum = DateTime.Now,
                    id_zaposlenik = 45127894124
                };
                context.racuns.Add(racun);
                context.SaveChanges();
                var zadnjiRacun = racun.ID;

                try
                {
                    for (int i = 0; i < dgvZaKucanje.Rows.Count - 1; i++)
                    {
                        var artiklID = dgvZaKucanje.Rows[i].Cells[0].Value.ToString();
                        var kolicina = dgvZaKucanje.Rows[i].Cells[3].Value.ToString();
                        stavka_racuna stavka = new stavka_racuna
                        {
                            id_racun = zadnjiRacun,
                            id_artikl = int.Parse(artiklID),
                            kolicina = int.Parse(kolicina)
                        };
                        context.stavka_racuna.Add(stavka);
                        context.SaveChanges();

                        var smanjiKolicinu = from artikl in context.artikls
                                             where artikl.ID.ToString() == artiklID.ToString()
                                             select artikl;

                        foreach (artikl artikl in smanjiKolicinu)
                        {
                            artikl.kolicina_na_zalihi = artikl.kolicina_na_zalihi - (double.Parse(kolicina) * artikl.normativ);
                        }
                        context.SaveChanges();

                    }
                        dgvZaKucanje.Rows.Clear();
                        dgvZaKucanje.Refresh();
                        txtSuma.Text = "";
                        MessageBox.Show("Uspješno kreiran račun!");
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Molimo izbrišite duplikat artikala");
                }
            }
        }
    }
    }


