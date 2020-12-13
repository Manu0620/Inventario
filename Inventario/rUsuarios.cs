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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void rUsuarios_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void MostrarDatos(DataSet DS)
        {
            List<Usuarios> lst = new List<Usuarios>();
            lst.Clear();

            foreach (DataRow dr in DS.Tables[0].Rows)
            {
                Usuarios c = new Usuarios();

                c.codigo = dr["codUsuario"].ToString().Trim();
                c.nombre = dr["nUsuario"].ToString().Trim();
                c.contrasena = dr["Password"].ToString().Trim();
                c.estado = dr["Estado"].ToString().Trim();
                c.nivel = dr["Nivel"].ToString().Trim();

                lst.Add(c);
                c = null;
            }

            usuariosBindingSource1.DataSource = lst;
            this.reportViewer1.RefreshReport();
        }
    }
}
