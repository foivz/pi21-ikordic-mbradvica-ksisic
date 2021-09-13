using FunctionBarDb;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FunctionBar.Forme
{
    public partial class PregledInventura : Form
    {
        public PregledInventura()
        {
            InitializeComponent();
        }

        //dodavanje vrijednosti provedenih inventura u datagridview pozivajuci metodu DohvatiInventure
        private void PregledInventura_Load(object sender, EventArgs e)
        {
            dgvInventure.DataSource = null;
            dgvInventure.DataSource = DohvatiInventure();
        }

        //dohvaćanje provedenih inventura iz baze podataka tre vracanje liste provedenih inventura
        private object DohvatiInventure()
        {
            using (var context = new FunctionBarDB())
            {
                var upit = from inventura in context.inventuras
                            join zaposlenik in context.zaposleniks on inventura.OIB equals zaposlenik.OIB
                            select new
                            {
                                Id_inventure = inventura.ID,
                                Datum_inventure = inventura.datum_inventure,
                                Ime_prezime = zaposlenik.ime + " " + zaposlenik.prezime
                            };

                return upit.ToList();
            }
        }

        //odabirom odredene inventure, poziva se metoda DohvatiArtikleInventure
        private void PrikaziArtikle(object sender, EventArgs e)
        {
            var index = dgvInventure.CurrentRow.Cells[0].Value;
            DohvatiArtikleInventure((int)index);
        }

        //Dohvacanje artikala, tocnije stavaka provedene inventure iz baze podataka
        private void DohvatiArtikleInventure(int id)
        {
            using (var context = new FunctionBarDB())
            {
                var upit = from artikli_inventure in context.artikli_inventure join artikl in context.artikls on artikli_inventure.ID_artikla equals
                            artikl.ID where artikli_inventure.ID_inventure == id
                            select new
                            {
                                Artikl = artikl.naziv,
                                Količina_na_zalihi = artikli_inventure.kolicina_na_zalihi,
                                Višak_manjak = artikli_inventure.visak_manjak,
                            };

                dgvArtikli.DataSource = upit.ToList();
            }
        }

        private void PregledInventura_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            /*string helpPoveznica = "FunctionBarHelp.chm";
            Help.ShowHelp(this, Environment.CurrentDirectory + "\\Resources\\" + helpPoveznica, HelpNavigator.Topic, "start.htm#_Toc43663407");*/
        }
    }



}
