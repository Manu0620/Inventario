using System.Windows.Forms;

namespace Inventario
{
    public partial class cClientes : Consultas
    {
        public cClientes()
        {
            InitializeComponent();
            dataCliente.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataCliente.DataSource = null;

            string cmd = "SELECT * FROM Clientes";;

            if (string.IsNullOrEmpty(bNombre.Text.Trim()) == false)
                cmd += "SELECT * FROM Clientes where nCliente like('%" + bNombre.Text.Trim() + "%')";
            else if (string.IsNullOrEmpty(bID.Text.Trim()) == false)
                cmd += "SELECT * FROM Clientes where codCliente like('%" + bID.Text.Trim() + "%')";

            DS = Utilidades.utilidades.ConectarSQL(cmd);

            if (Utilidades.utilidades.dsTieneDatos(DS))
                dataCliente.DataSource = DS.Tables[0];

        }

        public override void Imprimir()
        {
            rClientes obj = new rClientes();

            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                obj.MostrarDatos(DS);
                obj.ShowDialog();
            }
        }

        private void bSeleccionar_Click(object sender, System.EventArgs e)
        {
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }

}
