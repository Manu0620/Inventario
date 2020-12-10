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
    public partial class rFactura : Form
    {
        public rFactura()
        {
            InitializeComponent();
        }

        private void rFactura_Load(object sender, EventArgs e)
        {

        }

        public void MostrarDatos(DataSet DS)
        {
            List<Factura> lst = new List<Factura>();
            lst.Clear();

            foreach (DataRow dr in DS.Tables[0].Rows)
            {
                Factura c = new Factura();

                c.numero = dr["numfac"].ToString().Trim();
                c.fecha = dr["fecfac"].ToString().Trim();
                c.cliente = dr["codcli"].ToString().Trim();
                c.status = dr["status"].ToString().Trim();
                c.codigopro = dr["codProducto"].ToString().Trim();
                c.nombre = dr["nProducto"].ToString().Trim();
                c.canven = Convert.ToDouble(dr["canven"].ToString().Trim());
                c.preven = Convert.ToDouble(dr["preven"].ToString().Trim());
                c.email = dr["Email"].ToString().Trim();

                lst.Add(c);
                c = null;
            }

            facturaBindingSource1.DataSource = lst;
            this.reportViewer1.RefreshReport();
        }
    }
}
