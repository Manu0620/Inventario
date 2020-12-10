using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    public class Productos
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string preventa { get; set; }
        public string precompra { get; set; }
        public string existencia { get; set; }
        public string punreo { get; set; }
        public string status { get; set; }
        public string coddepartamento { get; set; }

        public Productos() { }
    }
}
