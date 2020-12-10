using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Login : Form
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

        public Login()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            DataSet DS;
            string cmd = string.Format("exec LoginUsuario '{0}','{1}','{2}'", bCodigo.Text.Trim(), bPassword.Text.Trim(), false);
            DS = Utilidades.utilidades.ConectarSQL(cmd);

            bool resultado = Convert.ToBoolean(DS.Tables[0].Rows[0]["Result"]);

            if (resultado)
            {
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Menu);
                Menu obj = new Menu();
                Bienvenido bienvenido = new Bienvenido();
                DS = Utilidades.utilidades.ConectarSQL("Select * From Usuarios where codUsuario='" + bCodigo.Text.Trim() + "'");

                if (frm != null)
                {
                    Advertencia.Visible = true;
                    Advertencia.Text = "      Menu abierto!";
                }
                else
                {
                    Advertencia.Visible = false;
                    Advertencia.Text = "";
                    bCodigo.Text = "";
                    bPassword.Text = "";
                    if (Utilidades.utilidades.dsTieneDatos(DS))
                    {
                        bienvenido.DarBienvenida(DS);
                        bienvenido.ShowDialog();
                    } 
                    obj.Show();
                }
            }
            else
            {
                Advertencia.Visible = true;
                Advertencia.Text = "      Contraseña incorrecta!";
            }
                
        }

    }
}

/*string cmd = string.Format("exec LoginUsuario '{0}','{1}','{2}'", bCodigo.Text.Trim(), bPassword.Text.Trim(), false);
DataSet DS = Utilidades.utilidades.ConectarSQL(cmd);

bool resultado = Convert.ToBoolean(DS.Tables[0].Rows[0]["Result"]);

if (resultado)
{
    Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Menu);
    Menu obj = new Menu();

    if (frm != null)
    {
        Advertencia.Visible = true;
        Advertencia.Text = "      Menu abierto!";
    }
    else
    {
        Advertencia.Visible = false;
        Advertencia.Text = "";
        bCodigo.Text = "";
        bPassword.Text = "";
        obj.Show();
    }
}
else
{
    Advertencia.Visible = true;
    Advertencia.Text = "      Contraseña incorrecta!";
}*/
