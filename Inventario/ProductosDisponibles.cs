using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ProductosDisponibles : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int left,
                int top,
                int right,
                int bottom,
                int width,
                int height
            );
        public DataSet DS;
        public ProductosDisponibles()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
            dataProductos.AutoGenerateColumns = false;
            Consultar();
        }

        public void Consultar()
        {
            DS = Utilidades.utilidades.ConectarSQL("Select * From Productos");

            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                dataProductos.DataSource = DS.Tables[0];
            }
            else
            {
                MessageBox.Show("No hay productos!");
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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
