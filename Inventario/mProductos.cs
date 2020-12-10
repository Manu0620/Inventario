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
    public partial class mProductos : Mantenimientos
    {
        public mProductos()
        {
            InitializeComponent();
        }

        private void bCodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(bCodigo.Text.Trim()))
                return;

            DS = Utilidades.utilidades.ConectarSQL("SELECT * FROM Productos WHERE codProducto='" + bCodigo.Text.Trim() + "'");
            bNombre.Text = "";
            bPreventa.Text = "";
            bPrecompra.Text = "";
            bExistencia.Text = "";
            bPunreo.Text = "";
            bCodDep.Text = "";


            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                bNombre.Text = DS.Tables[0].Rows[0]["nProducto"].ToString().Trim();
                bPreventa.Text = DS.Tables[0].Rows[0]["Preventa"].ToString().Trim();
                bPrecompra.Text = DS.Tables[0].Rows[0]["Precompra"].ToString().Trim();
                bExistencia.Text = DS.Tables[0].Rows[0]["ExiProducto"].ToString().Trim();
                bPunreo.Text = DS.Tables[0].Rows[0]["Punreo"].ToString().Trim();
                bCodDep.Text = DS.Tables[0].Rows[0]["codDepartamento"].ToString().Trim();
                ckEstado.Checked = Convert.ToBoolean(DS.Tables[0].Rows[0]["Status"]);
            }
            else
            {
                bNombre.Text = "";
                bPreventa.Text = "";
                bPrecompra.Text = "";
                bExistencia.Text = "";
                bPunreo.Text = "";
                bCodDep.Text = "";
                ckEstado.Checked = false;
            }
        }

        public override void Guardar()
        {
            if (Utilidades.utilidades.ValidaForm(this, errorProvider))
                return;

            string cmd = string.Format("exec productoActualiza '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                bCodigo.Text.Trim(), bNombre.Text.Trim(), bPreventa.Text.Trim(), bPrecompra.Text.Trim(), bExistencia.Text.Trim(), bPunreo.Text.Trim(), ckEstado.Checked, bCodDep.Text.Trim());

            DS = Utilidades.utilidades.ConectarSQL(cmd);
            Limpiar();
        }

        public override void Limpiar()
        {
            base.Limpiar();

            bCodigo.Text = "";
            bNombre.Text = "";
            bPreventa.Text = "";
            bPrecompra.Text = "";
            bExistencia.Text = "";
            bPunreo.Text = "";
            bCodDep.Text = "";
            ckEstado.Checked = false;
            bCodigo.Focus();
        }

        public override void Eliminar()
        {
            DS = Utilidades.utilidades.ConectarSQL("exec eliminaProducto '" + bCodigo.Text.Trim() + "'");
            Limpiar();
        }

        public override void Consultar()
        {
            cProductos obj = new cProductos();
            if (obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int pos = obj.dataProductos.CurrentCell.RowIndex;

                bCodigo.Text = obj.dataProductos.Rows[pos].Cells[0].Value.ToString().Trim();

                //segunda forma
                bCodigo_Validating(null, null);
            }
            obj.Dispose();
        }
    }
}
