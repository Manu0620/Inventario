using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class ProductosDisponibles : Form
    {
        public DataSet DS;
        public ProductosDisponibles()
        {
            InitializeComponent();
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
    }
}
