using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBarDb
{
    public partial class vrsta_artikla
    {
        public override string ToString()
        {
            return naziv;
        }

        public Image slika
        {
            get
            {
                if (!string.IsNullOrEmpty(putanja))
                {
                    string startupPath = Environment.CurrentDirectory + "\\Resources\\" + putanja;
                    Console.WriteLine(startupPath);
                    try
                    {
                        return Image.FromFile(startupPath);
                    }
                    catch
                    {

                    }
                }
                return null;
            }
        }

    }
}
