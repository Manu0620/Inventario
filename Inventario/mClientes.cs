using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Inventario
{
    public partial class mClientes : Mantenimientos
    {
        public mClientes()
        {
            InitializeComponent();
        }

        private void bCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(bCodigo.Text.Trim()))
                return;

            DS = Utilidades.utilidades.ConectarSQL("SELECT * FROM Clientes WHERE codCliente='" + bCodigo.Text.Trim() + "'");
            bNombre.Text = "";
            bEmail.Text = "";
            bDireccion.Text = "";

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                bNombre.Text = DS.Tables[0].Rows[0]["nCliente"].ToString().Trim();
                bEmail.Text = DS.Tables[0].Rows[0]["Email"].ToString().Trim();
                bDireccion.Text = DS.Tables[0].Rows[0]["Direccion"].ToString().Trim();
                ckEstado.Checked = Convert.ToBoolean(DS.Tables[0].Rows[0]["Status"]);
            }
            else
            {
                bNombre.Text = "";
                bEmail.Text = "";
                bDireccion.Text = "";
                ckEstado.Checked = false;
            }
        }

        public override void Guardar()
        {
            if (Utilidades.utilidades.ValidaForm(this, errorProvider))
                return;

            string cmd = string.Format("exec clientesActualiza '{0}','{1}','{2}','{3}','{4}'",
                bCodigo.Text.Trim(), bNombre.Text.Trim(), bEmail.Text.Trim(), bDireccion.Text.Trim(), ckEstado.Checked);

            DS = Utilidades.utilidades.ConectarSQL(cmd);
            Limpiar();
        }

        public override void Limpiar()
        {
            base.Limpiar();

            bCodigo.Text = "";
            bNombre.Text = "";
            bEmail.Text = "";
            bDireccion.Text = "";
            ckEstado.Checked = false;
            bCodigo.Focus();
        }

        public override void Eliminar()
        {
            DS = Utilidades.utilidades.ConectarSQL("exec eliminaCliente '" + bCodigo.Text.Trim() + "'");
            Limpiar();
        }

        public override void Consultar()
        {
            cClientes obj = new cClientes();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                int pos = obj.dataCliente.CurrentCell.RowIndex;

                bCodigo.Text = obj.dataCliente.Rows[pos].Cells[0].Value.ToString().Trim();

                bCodigo_Validating(null, null);
            }
            obj.Dispose();
        }
    }
}
