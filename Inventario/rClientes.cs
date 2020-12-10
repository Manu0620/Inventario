using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace Inventario
{
    public partial class rClientes : Form
    {
        public rClientes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'InventarioDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.ClientesTableAdapter.Fill(this.InventarioDataSet.Clientes);
        }

        public void MostrarDatos(DataSet DS)
        {
            List<Clientes> lst = new List<Clientes>();
            lst.Clear();

            foreach (DataRow dr in DS.Tables[0].Rows)
            {
                Clientes c = new Clientes();

                c.codigo = dr["codCliente"].ToString().Trim();
                c.nombre = dr["nCliente"].ToString().Trim();
                c.email = dr["Email"].ToString().Trim();
                c.direccion = dr["Direccion"].ToString().Trim();
                c.status = dr["Status"].ToString().Trim();

                lst.Add(c);
                c = null;
            }

            clientesBindingSource1.DataSource = lst;
            this.reportViewer1.RefreshReport();
        }
    }
}
