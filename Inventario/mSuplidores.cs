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
    public partial class mSuplidores : Mantenimientos
    {
        public mSuplidores()
        {
            InitializeComponent();
        }

        private void bCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(bCodigo.Text.Trim()))
                return;

            DS = Utilidades.utilidades.ConectarSQL("SELECT * FROM Suplidor WHERE codSuplidor='" + bCodigo.Text.Trim() + "'");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                bNombre.Text = DS.Tables[0].Rows[0]["nSuplidor"].ToString().Trim();
                ckEstado.Checked = Convert.ToBoolean(DS.Tables[0].Rows[0]["Status"]);
                bEmail.Text = DS.Tables[0].Rows[0]["Email"].ToString().Trim();
                bDireccion.Text = DS.Tables[0].Rows[0]["Direccion"].ToString().Trim();
            }
            else
            {
                bNombre.Text = "";
                ckEstado.Checked = false;
                bEmail.Text = "";
                bDireccion.Text = "";
            }
        }

        public override void Guardar()
        {
            if (Utilidades.utilidades.ValidaForm(this, errorProvider))
                return;

            string cmd = string.Format("exec suplidorActualiza '{0}','{1}','{2}','{3}','{4}'",
                bCodigo.Text.Trim(), bNombre.Text.Trim(), bEmail.Text.Trim(), ckEstado.Checked, bDireccion.Text.Trim());

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
            DS = Utilidades.utilidades.ConectarSQL("DELETE FROM Suplidor WHERE codSuplidor='" + bCodigo.Text.Trim() + "'");
            Limpiar();
        }

        public override void Consultar()
        {
            cSuplidores obj = new cSuplidores();
            if (obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int pos = obj.dataSuplidor.CurrentCell.RowIndex;

                bCodigo.Text = obj.dataSuplidor.Rows[pos].Cells[0].Value.ToString().Trim();

                //segunda forma
                bCodigo_Validating(null, null);
            }
            obj.Dispose();
        }
    }
}
