using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Bienvenido : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
                int left,
                int top,
                int right,
                int bottom,
                int width,
                int height
            );
        public Bienvenido()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        public void DarBienvenida(DataSet DS)
        {
            string nombre = DS.Tables[0].Rows[0]["nUsuario"].ToString().Trim();
            Bienvenida.Text = "Bienvenido/a " + nombre; 
        }
    }
}
