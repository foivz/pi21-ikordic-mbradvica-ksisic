using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionBar.Forme;

namespace FunctionBar
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PrijavaForm prijava = new PrijavaForm();

            //GlavnaForma frm = new GlavnaForma();

            Application.Run(prijava);

        }
    }
}
