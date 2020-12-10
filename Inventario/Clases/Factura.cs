using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class Factura
    {
        public string numero { get; set; }
        public string fecha { get; set; }
        public string status { get; set; }
        public string cliente { get; set; }
        public string email { get; set; }
        public string codigopro { get; set; }
        public string nombre { get; set; }
        public double canven { get; set; }
        public double preven { get; set; }


        public Factura() { }
    }
}
