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
    public partial class rVentasEntreFecha : Form
    {
        public rVentasEntreFecha()
        {
            InitializeComponent();
        }

        private void rVentasEntreFecha_Load(object sender, EventArgs e)
        {

        }

        public void MostrarDatos(DataSet DS)
        {
            List<Ventasentrefecha> lst = new List<Ventasentrefecha>();
            lst.Clear();

            foreach(DataRow dr in DS.Tables[0].Rows)
            {
                Ventasentrefecha clase = new Ventasentrefecha();

                clase.numero = dr["numfac"].ToString().Trim();
                clase.fecha = dr["fecfac"].ToString().Trim();
                clase.estado = dr["status"].ToString().Trim();
                clase.cliente = dr["nCliente"].ToString().Trim();
                clase.email = dr["Email"].ToString().Trim();
                clase.total = Convert.ToDouble(dr["total"].ToString());

                lst.Add(clase);
                clase = null;
            }

            ventasentrefechaBindingSource1.DataSource = lst;
            reportViewer1.RefreshReport();
        }
    }
}
