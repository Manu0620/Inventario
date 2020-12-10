using System;
using System.Windows.Forms;

namespace Inventario
{
    public partial class cUnidades : Consultas
    {
        public cUnidades()
        {
            InitializeComponent();
        }

        public override void Consultar()
        {
            dataUnidades.DataSource = null;

            string cmd = "SELECT * FROM Unidades";

            if (string.IsNullOrEmpty(bDescripcion.Text.Trim()) == false)
                cmd += " where desuni like('%" + bDescripcion.Text.Trim() + "%')";
            else if (string.IsNullOrEmpty(bID.Text.Trim()) == false)
                cmd += " where coduni like('%" + bID.Text.Trim() + "%')";

            DS = Utilidades.utilidades.ConectarSQL(cmd);

            if (Utilidades.utilidades.dsTieneDatos(DS))
                dataUnidades.DataSource = DS.Tables[0];
        }

        private void bSeleccionar_Click(object sender, EventArgs e)
        {
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public override void Imprimir()
        {
            if (Utilidades.utilidades.dsTieneDatos(DS)) 
            {
                rUnidades obj = new rUnidades();

                obj.MostrarDatos(DS);
                obj.ShowDialog();
            }
        }
    }
}
