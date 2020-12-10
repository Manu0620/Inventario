using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class cDepartamentos : Consultas
    {
        public cDepartamentos()
        {
            InitializeComponent();
            dataDepartamentos.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataDepartamentos.DataSource = null;

            string cmd = "SELECT * FROM Departamentos";

            if (string.IsNullOrEmpty(bDescripcion.Text.Trim()) == false)
                cmd += " where desdep like('%" + bDescripcion.Text.Trim() + "%')";
            else if (string.IsNullOrEmpty(bID.Text.Trim()) == false)
                cmd += " where codDepartamentos like('%" + bID.Text.Trim() + "%')";

            DS = Utilidades.utilidades.ConectarSQL(cmd);

            if (Utilidades.utilidades.dsTieneDatos(DS))
                dataDepartamentos.DataSource = DS.Tables[0];
        }

        public override void Imprimir()
        {
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                rDepartamentos obj = new rDepartamentos();

                obj.MostrarDatos(DS);
                obj.ShowDialog();
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
