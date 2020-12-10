using System;
using System.ComponentModel;
using System.Data;

namespace Inventario
{
    public partial class mUnidades : Mantenimientos
    {
        public mUnidades()
        {
            InitializeComponent();
        }

        private void bCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(bCodigo.Text.Trim()))
                return;

            DS = Utilidades.utilidades.ConectarSQL("SELECT * FROM Unidades WHERE coduni='" + bCodigo.Text.Trim() + "'");
            bDescripcion.Text = "";

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                bDescripcion.Text = DS.Tables[0].Rows[0]["desuni"].ToString().Trim();
                ckEstado.Checked = Convert.ToBoolean(DS.Tables[0].Rows[0]["status"]);
            }
            else
            {
                bDescripcion.Text = "";
                ckEstado.Checked = false;
            }
        }

        public override void Guardar()
        {
            if (Utilidades.utilidades.ValidaForm(this, errorProvider))
                return;

            string cmd = string.Format("exec unidadesActualiza '{0}','{1}','{2}'",
                bCodigo.Text.Trim(), bDescripcion.Text.Trim(), ckEstado.Checked);

            DataSet DS = Utilidades.utilidades.ConectarSQL(cmd);
            Limpiar();
        }

        public override void Limpiar()
        {
            base.Limpiar();

            bCodigo.Text = "";
            bDescripcion.Text = "";
            ckEstado.Checked = false;
            bCodigo.Focus();
        }

        public override void Eliminar()
        {
            DS = Utilidades.utilidades.ConectarSQL("DELETE FROM Unidades WHERE coduni='" + bCodigo.Text.Trim() + "'");
        }

        public override void Consultar()
        {
            cUnidades obj = new cUnidades();
            if (obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int pos = obj.dataUnidades.CurrentCell.RowIndex;

                bCodigo.Text = obj.dataUnidades.Rows[pos].Cells[0].Value.ToString().Trim();

                //segunda forma
                bCodigo_Validating(null, null);
            }
            obj.Dispose();
        }
    }
}
