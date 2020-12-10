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
    public partial class rDepartamentos : Form
    {
        public rDepartamentos()
        {
            InitializeComponent();
        }

        private void rDepartamentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Departamentos' Puede moverla o quitarla según sea necesario.
            this.DepartamentosTableAdapter.Fill(this.InventarioDataSet.Departamentos);
        }

        public void MostrarDatos(DataSet DS)
        {
            List<Departamentos> lst = new List<Departamentos>();
            lst.Clear();

            foreach (DataRow dr in DS.Tables[0].Rows)
            {
                Departamentos c = new Departamentos();

                c.codigo = dr["codDepartamentos"].ToString().Trim();
                c.descripcion = dr["desdep"].ToString().Trim();
                c.Status = dr["status"].ToString().Trim();

                lst.Add(c);
                c = null;
            }

            departamentosBindingSource1.DataSource = lst;
            this.reportViewer1.RefreshReport();
        }
    }
}
