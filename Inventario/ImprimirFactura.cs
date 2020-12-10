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
    public partial class ImprimirFactura : Form
    {
        public ImprimirFactura()
        {
            InitializeComponent();
        }

        private void ImprimirFactura_Load(object sender, EventArgs e)
        {

        }

        public void MostrarDatos(DataSet DS)
        {
            List<ProductosVendidos> lst = new List<ProductosVendidos>();
            List<Clases.FacturaCliente> lst1 = new List<Clases.FacturaCliente>();
            lst.Clear();
            lst1.Clear();

            Clases.FacturaCliente fc = new Clases.FacturaCliente();
            fc.Numero = DS.Tables[0].Rows[0]["numfac"].ToString().Trim();
            fc.fecha = DS.Tables[0].Rows[0]["fecfac"].ToString().Trim();
            fc.codigocli = DS.Tables[0].Rows[0]["codCliente"].ToString().Trim();
            fc.nomcli = DS.Tables[0].Rows[0]["nCliente"].ToString().Trim();
            fc.email = DS.Tables[0].Rows[0]["Email"].ToString().Trim();
            lst1.Add(fc);

            foreach (DataRow row in DS.Tables[0].Rows)
            {
                ProductosVendidos pv = new ProductosVendidos();

                pv.cantidad = row["canven"].ToString().Trim();
                pv.nombre = row["nProducto"].ToString().Trim();
                pv.precio = row["preven"].ToString().Trim();
                pv.importe = Convert.ToDouble(row["canven"]) * Convert.ToDouble(row["preven"]);

                lst.Add(pv);
                pv = null;
            }

            productosVendidosBindingSource.DataSource = lst;
            facturaClienteBindingSource.DataSource = lst1;
            this.reportViewer1.RefreshReport();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
