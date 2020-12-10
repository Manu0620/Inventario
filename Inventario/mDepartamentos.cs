using System;
using System.ComponentModel;
using System.Data;


namespace Inventario
{
    public partial class mDepartamentos : Mantenimientos
    {
        public mDepartamentos()
        {
            InitializeComponent();
        }

        private void bCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(bCodigo.Text.Trim()))
                return;

            DS = Utilidades.utilidades.ConectarSQL("SELECT * FROM Departamentos WHERE codDepartamentos='" + bCodigo.Text.Trim() + "'");
            bDescripcion.Text = "";

            if(DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                bDescripcion.Text = DS.Tables[0].Rows[0]["desdep"].ToString().Trim();
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

            string cmd = string.Format("exec departamentosActualiza '{0}','{1}','{2}'",
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
            DS = Utilidades.utilidades.ConectarSQL("DELETE FROM Departamentos WHERE codDepartamentos='" + bCodigo.Text.Trim() + "'");
            Limpiar();
        }

        public override void Consultar()
        {
            cDepartamentos obj = new cDepartamentos();
            if (obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int pos = obj.dataDepartamentos.CurrentCell.RowIndex;

                bCodigo.Text = obj.dataDepartamentos.Rows[pos].Cells[0].Value.ToString().Trim();

                //segunda forma
                bCodigo_Validating(null, null);
            }
            obj.Dispose();
        }
    }
}
