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
    public partial class mUsuario : Mantenimientos
    {
        public mUsuario()
        {
            InitializeComponent();
        }

        private void bCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(bCodigo.Text.Trim()))
                return;

            DS = Utilidades.utilidades.ConectarSQL("SELECT * FROM Usuarios WHERE codUsuario='" + bCodigo.Text.Trim() + "'");
            bNombre.Text = "";
            bPassword.Text = "";
            bNivel.Text = "";

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                bNombre.Text = DS.Tables[0].Rows[0]["nUsuario"].ToString().Trim();
                bPassword.Text = DS.Tables[0].Rows[0]["Password"].ToString().Trim();
                bNivel.Text = DS.Tables[0].Rows[0]["Nivel"].ToString().Trim();
                ckEstado.Checked = Convert.ToBoolean(DS.Tables[0].Rows[0]["Estado"]);
            }
            else
            {
                bNombre.Text = "";
                bPassword.Text = "";
                bNivel.Text = "";
                ckEstado.Checked = false;
            }
        }

        public override void Guardar()
        {
            if (Utilidades.utilidades.ValidaForm(this, errorProvider))
                return;

            string cmd = string.Format("exec LoginUsuario '{0}','{1}','{2}'", bCodigo.Text.Trim(), bPassword.Text.Trim(), false);

            DS = Utilidades.utilidades.ConectarSQL(cmd);
            bool resultado = Convert.ToBoolean(DS.Tables[0].Rows[0]["Result"]);

            if (resultado)
            {

                int nivel = Convert.ToInt32(bNivel.Text.Trim());
                if (nivel >= 1 && nivel <= 5)
                {
                    cmd = string.Format("exec usuarioActualiza '{0}','{1}','{2}','{3}','{4}'",
                    bCodigo.Text.Trim(), bNombre.Text.Trim(), bPassword.Text.Trim(), ckEstado.Checked, bNivel.Text.Trim());

                    DS = Utilidades.utilidades.ConectarSQL(cmd);
                    Limpiar();
                }
                else
                    MessageBox.Show("El nivel debe ser del 1 al 5");

            }
            else
            {
                MessageBox.Show("Debes poner la contraseña correctamente para hacer cambios en este usuario!");
                return;
            }
            
        }

        public override void Limpiar()
        {
            base.Limpiar();

            bCodigo.Text = "";
            bNombre.Text = "";
            bPassword.Text = "";
            bNivel.Text = "";
            ckEstado.Checked = false;
            bCodigo.Focus();
        }

        public override void Eliminar()
        {
            DS = Utilidades.utilidades.ConectarSQL("DELETE FROM Usuarios WHERE codUsuario='" + bCodigo.Text.Trim() + "'");
            Limpiar();
        }

        public override void Consultar()
        {
            cUsuarios obj = new cUsuarios();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                int pos = obj.dataUsuario.CurrentCell.RowIndex;

                bCodigo.Text = obj.dataUsuario.Rows[pos].Cells[0].Value.ToString().Trim();

                bCodigo_Validating(null, null);
            }
            obj.Dispose();
        }
    }
}
