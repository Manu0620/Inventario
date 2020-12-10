using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class cProductos : Consultas
    {
        public cProductos()
        {
            InitializeComponent();
            dataProductos.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataProductos.DataSource = null;

            string cmd = "SELECT * FROM Productos";

            if (string.IsNullOrEmpty(bNombre.Text.Trim()) == false)
                cmd += " where nProducto like('%" + bNombre.Text.Trim() + "%')";
            else if (string.IsNullOrEmpty(bID.Text.Trim()) == false)
                cmd += " where codProducto like('%" + bID.Text.Trim() + "%')";

            DS = Utilidades.utilidades.ConectarSQL(cmd);

            if (Utilidades.utilidades.dsTieneDatos(DS))
                dataProductos.DataSource = DS.Tables[0];
        }

        public override void Imprimir()
        {
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                rProductos obj = new rProductos();

                obj.MostrarDatos(DS);
                obj.ShowDialog();
            }
        }

        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}
