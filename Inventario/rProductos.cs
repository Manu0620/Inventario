using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Inventario
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }

        private void rProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.ProductosTableAdapter.Fill(this.InventarioDataSet.Productos);
        }

        public void MostrarDatos(DataSet DS)
        {
            List<Productos> lst = new List<Productos>();
            lst.Clear();

            foreach (DataRow dr in DS.Tables[0].Rows)
            {
                Productos c = new Productos();

                c.codigo = dr["codProducto"].ToString().Trim();
                c.nombre = dr["nProducto"].ToString().Trim();
                c.preventa = dr["Preventa"].ToString().Trim();
                c.precompra = dr["Precompra"].ToString().Trim();
                c.existencia = dr["ExiProducto"].ToString().Trim();
                c.punreo = dr["Punreo"].ToString().Trim();
                c.status = dr["Status"].ToString().Trim();
                c.coddepartamento = dr["codDepartamento"].ToString().Trim();
                lst.Add(c);
                c = null;
            }

            productosBindingSource1.DataSource = lst;
            this.reportViewer1.RefreshReport();
        }
    }
}
