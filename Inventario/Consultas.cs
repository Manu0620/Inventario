using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Consultas : FormBase 
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void bImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        public override void Consultar()
        {
            base.Consultar();
        }

        public override void Imprimir()
        {
            base.Imprimir();
        }
    }
}
