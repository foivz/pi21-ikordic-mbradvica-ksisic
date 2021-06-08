using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionBarDb
{
   public static class UpravljanjeRačunima
    {
        private static int trenutnaUloga;
        private static long trenutniOIB;
        public static bool ispravno = false;

        public static void ProvjeriUnose(string korime, string lozinka)
        {
            using (var context=new FunctionBarDB())
            {
                var upitPrijava = from zaposlenik in context.zaposleniks
                                  join vrsta in context.vrsta_uloge
                                  on zaposlenik.id_vrsta_uloge equals vrsta.ID
                                  where zaposlenik.korisnicko_ime == korime && zaposlenik.lozinka == lozinka
                                  select zaposlenik;
                if (upitPrijava.FirstOrDefault() !=null)
                {
                    trenutnaUloga = upitPrijava.FirstOrDefault().id_vrsta_uloge;
                    trenutniOIB = upitPrijava.FirstOrDefault().OIB;
                    ispravno = true;
                }
                              
                                
            }

        }

        public static int VratiTrenutnuUlogu()
        {
            return trenutnaUloga;
        }
        
        public static long VratiTrenutniOIB()
        {
            return trenutniOIB;
        }
          
    }
}
