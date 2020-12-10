namespace Inventario
{
    public partial class cDetalles : Consultas
    {
        public cDetalles()
        {
            InitializeComponent();
            dataDetalles.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataDetalles.DataSource = null;

            string cmd = "SELECT * FROM Detalles";

            if (string.IsNullOrEmpty(bNumero.Text.Trim()) == false)
                cmd += " where numfac like('%" + bNumero.Text.Trim() + "%')";

            DS = Utilidades.utilidades.ConectarSQL(cmd);

            if (Utilidades.utilidades.dsTieneDatos(DS))
                dataDetalles.DataSource = DS.Tables[0];
        }
    }
}
