using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Mantenimientos : FormBase
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void bConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }


        public override void Guardar()
        {
            base.Guardar();
        }

        public override void Limpiar()
        {
            base.Limpiar();
        }

        public override void Eliminar()
        {
            base.Eliminar();
        }

        public override void Consultar()
        {
            base.Consultar();
        }
    }
}
