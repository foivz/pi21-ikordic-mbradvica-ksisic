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
    public partial class RacuniForm : Form
    {
        public RacuniForm()
        {
            InitializeComponent();
       
        }

        private void RacuniForm_Load(object sender, EventArgs e)
        {
            if (UpravljanjeRačunima.VratiTrenutnuUlogu() == 2)
            {
                btnStorniraj.Visible = false;
            }
            Osvjezi(0);
            cbFiltrirajRacune.Items.Add("Aktivni");
            cbFiltrirajRacune.Items.Add("Stornirani");
            cbFiltrirajRacune.SelectedIndex = 0;
        }

        private void Osvjezi(int index)
        {
            dgvSviRacuni.DataSource = null;
            PrikaziRacune(index);
        }


        //prikaz svih računa, grupira se po ID-u
        private void PrikaziRacune(int index)
        {
            using (var context = new FunctionBarDB())
            {
                if (index==0)
                {
                    var upit = from racun in context.racuns
                               join zaposlenik in context.zaposleniks on racun.id_zaposlenik equals zaposlenik.OIB
                               join stavka_racuna in context.stavka_racuna on racun.ID equals stavka_racuna.id_racun
                               join artikl in context.artikls on stavka_racuna.id_artikl equals artikl.ID
                               where racun.storniran == false || racun.storniran == null
                               select new
                               {
                                   racun.ID,
                                   racun.datum,
                                   zaposlenik.ime,
                                   zaposlenik.prezime
                               } into x
                               group x by x.ID into g
                               select new
                               {
                                   Id = g.Key,
                                   Datum = g.Select(x => x.datum).FirstOrDefault(),
                                   Ime = g.Select(x => x.ime + " " + x.prezime).FirstOrDefault()
                               };

                    dgvSviRacuni.DataSource = upit.ToList();
                }
                else
                {
                    var upit = from racun in context.racuns
                               join zaposlenik in context.zaposleniks on racun.id_zaposlenik equals zaposlenik.OIB
                               join stavka_racuna in context.stavka_racuna on racun.ID equals stavka_racuna.id_racun
                               join artikl in context.artikls on stavka_racuna.id_artikl equals artikl.ID
                               where racun.storniran ==true
                               select new
                               {
                                   racun.ID,
                                   racun.datum,
                                   zaposlenik.ime,
                                   zaposlenik.prezime
                               } into x
                               group x by x.ID into g
                               select new
                               {
                                   Id = g.Key,
                                   Datum = g.Select(x => x.datum).FirstOrDefault(),
                                   Ime = g.Select(x => x.ime + " " + x.prezime).FirstOrDefault()
                               };

                    dgvSviRacuni.DataSource = upit.ToList();
                }
        
                         }
        }

        //metoda za dohvaćanje stavki računa na temelju id-a računa
        private void DohvatiStavkeRacuna(int id)
        {
            using (var context=new FunctionBarDB())
            {
                var upit = from stavka_racuna in context.stavka_racuna
                           join artikl in context.artikls on stavka_racuna.id_artikl equals artikl.ID
                           where stavka_racuna.id_racun == id
                           select new
                           {
                               Id = artikl.ID,
                               Artikl = artikl.naziv,
                               Količina = stavka_racuna.kolicina,
                               Na_zalihi=artikl.kolicina_na_zalihi
                           };
                dgvStavkeRacuna.DataSource = upit.ToList();
            }
        }

        //ID računa je prva ćelija u dgvSviRacuni te se prema njoj dohvaćaju stavke tog računa
        private void dgvSviRacuni_SelectionChanged(object sender, EventArgs e)
        {
            var index = dgvSviRacuni.CurrentRow.Cells[0].Value;
            DohvatiStavkeRacuna((int)index);
        }

        private void btnStorniraj_Click(object sender, EventArgs e)
        {
            var idRacuna = dgvSviRacuni.CurrentRow.Cells[0].Value;
            var idArtikla = dgvStavkeRacuna.CurrentRow.Cells[1].Value.ToString();
            var kolicina = dgvStavkeRacuna.CurrentRow.Cells[3].Value.ToString();

            using (var context = new FunctionBarDB())
            {
                var query = from racun in context.racuns
                            where racun.ID == (int)idRacuna
                            select racun;

                var vratiKolicinu = from racun in context.racuns
                                    join stavka in context.stavka_racuna on racun.ID equals stavka.id_racun
                                    join artikl in context.artikls on stavka.id_artikl equals artikl.ID
                                    where racun.ID == (int)idRacuna
                                    select artikl;

                using (var context2 = new FunctionBarDB())
                {
                    var test = from racun in context.racuns
                               join stavka in context.stavka_racuna on racun.ID equals stavka.id_racun
                               join artikl in context.artikls on stavka.id_artikl equals artikl.ID
                               where racun.ID == (int)idRacuna
                               select new
                               {
                                   artikl.ID,
                                   artikl.naziv,
                                   stavka.kolicina


                               };
                    foreach (artikl item in vratiKolicinu)
                    {
                        foreach (var item2 in test)
                        {
                            if (item.ID == item2.ID)
                            {
                                item.kolicina_na_zalihi += item2.kolicina * item.normativ;
                            }
                        }
                    }
                }

                foreach (racun item in query)
                {
                    item.storniran = true;
                    

                }

                context.SaveChanges();






            }
            Osvjezi(0);
        }

        private void cbFiltrirajRacune_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFiltrirajRacune.SelectedIndex)
            {
                case 0:
                    if(UpravljanjeRačunima.VratiTrenutnuUlogu()==2)
                    {
                        btnStorniraj.Visible = false;
                        dgvSviRacuni.DataSource = null;
                        Osvjezi(0);
                    }
                    else
                    {
                        btnStorniraj.Visible = true;
                        dgvSviRacuni.DataSource = null;
                        Osvjezi(0);
                    }               
                    break;
                case 1:
                    btnStorniraj.Visible = false;
                    dgvSviRacuni.DataSource = null;
                    Osvjezi(1);
                    break;
            }
        }
    }
}
