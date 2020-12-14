using System;

namespace Inventario
{
    public partial class cVentasEntreFechas : Consultas
    {
        public cVentasEntreFechas()
        {
            InitializeComponent();
            dataVentas.AutoGenerateColumns = false;
        }

        public override void Consultar()
        {
            dataVentas.DataSource = null;

            string cmd = string.Format("exec ventasentrefecha '{0}','{1}','{2}'", bFinicial.Text.Trim(), bFfinal.Text.Trim(), bCliente.Text.Trim());

            DS = Utilidades.utilidades.ConectarSQL(cmd);
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                dataVentas.DataSource = DS.Tables[0];
            }

        }

        public override void Imprimir()
        {
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                rVentasEntreFecha obj = new rVentasEntreFecha();
                obj.MostrarDatos(DS);
                obj.ShowDialog();
            }
        }
    }
}
