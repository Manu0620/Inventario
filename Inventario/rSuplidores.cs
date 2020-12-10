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
    public partial class rSuplidores : Form
    {
        public rSuplidores()
        {
            InitializeComponent();
        }

        private void rSuplidores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Suplidor' Puede moverla o quitarla según sea necesario.
            this.SuplidorTableAdapter.Fill(this.InventarioDataSet.Suplidor);

        }

        public void MostrarDatos(DataSet DS)
        {
            List<Suplidores> lst = new List<Suplidores>();
            lst.Clear();

            foreach (DataRow dr in DS.Tables[0].Rows)
            {
                Suplidores c = new Suplidores();

                c.codigo = dr["codSuplidor"].ToString().Trim();
                c.nombre = dr["nSuplidor"].ToString().Trim();
                c.email = dr["Email"].ToString().Trim();
                c.Status = dr["Status"].ToString().Trim();
                c.direccion = dr["Direccion"].ToString().Trim();

                lst.Add(c);
                c = null;
            }

            suplidoresBindingSource2.DataSource = lst;
            this.reportViewer1.RefreshReport();
        }
    }
}
