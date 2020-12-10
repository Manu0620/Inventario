using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace Inventario
{
    public partial class Acerca : Form
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

        public Acerca()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
