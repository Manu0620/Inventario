﻿

namespace Inventario.Clases
{
    class FacturaCliente
    {
        public string Numero { get; set; }
        public string fecha { get; set; }
        public string codigocli { get; set; }
        public string nomcli { get; set; }
        public string email { get; set; }
        public string vendedor { get; set; }
        public string codvendedor { get; set; }

        public FacturaCliente() { }
    }
}
