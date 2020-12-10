using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class cSuplidores : Consultas
    {
        public cSuplidores()
        {
            InitializeComponent();
        }

        public override void Consultar()
        {
            dataSuplidor.DataSource = null;

            string cmd = "SELECT * FROM Suplidor";

            if (string.IsNullOrEmpty(bNombre.Text.Trim()) == false)
                cmd += " where nSuplidor like('%" + bNombre.Text.Trim() + "%')";
            else if (string.IsNullOrEmpty(bID.Text.Trim()) == false)
                cmd += " where codSuplidor like('%" + bID.Text.Trim() + "%')";

            DS = Utilidades.utilidades.ConectarSQL(cmd);

            if (Utilidades.utilidades.dsTieneDatos(DS))
                dataSuplidor.DataSource = DS.Tables[0];
        }

        public override void Imprimir()
        {
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                rSuplidores obj = new rSuplidores();

                obj.MostrarDatos(DS);
                obj.ShowDialog();
            }

        }

        private void bSeleccionar_Click_1(object sender, EventArgs e)
        {
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
