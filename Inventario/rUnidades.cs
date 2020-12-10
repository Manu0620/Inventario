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
    public partial class rUnidades : Form
    {
        public rUnidades()
        {
            InitializeComponent();
        }

        private void rUnidades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Unidades' Puede moverla o quitarla según sea necesario.
            this.UnidadesTableAdapter.Fill(this.InventarioDataSet.Unidades);
        }

        public void MostrarDatos(DataSet DS)
        {
            List<Unidades> lst = new List<Unidades>();
            lst.Clear();

            foreach (DataRow dr in DS.Tables[0].Rows)
            {
                Unidades c = new Unidades();

                c.codigo = dr["coduni"].ToString().Trim();
                c.descripcion = dr["desuni"].ToString().Trim();
                c.status = dr["status"].ToString().Trim();

                lst.Add(c);
                c = null;
            }

            unidadesBindingSource1.DataSource = lst;
            this.reportViewer1.RefreshReport();
        }
    }
}
