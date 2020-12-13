using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class cUsuarios : Consultas
    {
        public cUsuarios()
        {
            InitializeComponent();
            dataUsuario.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataUsuario.DataSource = null;

            string cmd = "SELECT * FROM Usuarios";

            if (string.IsNullOrEmpty(bNombre.Text.Trim()) == false)
                cmd += " where nUsuario like('%" + bNombre.Text.Trim() + "%')";
            else if (string.IsNullOrEmpty(bID.Text.Trim()) == false)
                cmd += " where codUsuario like('%" + bID.Text.Trim() + "%')";

            DS = Utilidades.utilidades.ConectarSQL(cmd);

            if (Utilidades.utilidades.dsTieneDatos(DS))
                dataUsuario.DataSource = DS.Tables[0];
        }

        public override void Imprimir()
        {
            rUsuarios obj = new rUsuarios();
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                obj.MostrarDatos(DS);
                obj.Show();
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
