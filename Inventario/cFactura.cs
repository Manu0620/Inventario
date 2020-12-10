using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class cFactura : Consultas
    {
        public cFactura()
        {
            InitializeComponent();
            dataFactura.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataFactura.DataSource = null;

            string cmd = string.Format("exec DatosFactura '{0}'", bNumero.Text.Trim());

            DS = Utilidades.utilidades.ConectarSQL(cmd);

            if (Utilidades.utilidades.dsTieneDatos(DS))
                dataFactura.DataSource = DS.Tables[0];
        }

        public override void Imprimir()
        {
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                rFactura obj = new rFactura();

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
