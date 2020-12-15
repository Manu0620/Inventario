using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Inventario
{
    public partial class Menu : Form
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

        private int childFormNumber, Nivel = 0;
        private string codusuario, nomusuario = string.Empty;

        public Menu()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca obj = new Acerca();
            obj.Show();
        }

        private void ejemplosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplos obj = new Ejemplos();
            //obj.MdiParent = this;
            obj.Show();
        }

        public void NivelUsuario(DataSet DS)
        {
            Nivel = Convert.ToInt32(DS.Tables[0].Rows[0]["Nivel"].ToString());
            usuario.Text ="Logueado como: "+DS.Tables[0].Rows[0]["nUsuario"].ToString();
            nomusuario = DS.Tables[0].Rows[0]["nUsuario"].ToString();
            codusuario = DS.Tables[0].Rows[0]["codUsuario"].ToString();
            switch (Nivel)
            {
                case 2:
                    {
                        usuariosToolStripMenuItem.Enabled = false;
                    }
                    break;
                case 3:
                    {
                        tsMantenimientos.Enabled = false;
                    }
                    break;
                case 4:
                    {
                        tsMantenimientos.Enabled = false;
                        facturaToolStripMenuItem1.Enabled = false;
                    }
                    break;
                case 5:
                    {
                        tsMantenimientos.Enabled = false;
                        facturaToolStripMenuItem1.Enabled = false;
                        tsProcesos.Enabled = false;
                    }
                    break;
                default: break;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MdiClient cltMdi;
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    cltMdi = (MdiClient)ctl;
                    cltMdi.BackColor = this.BackColor;
                }catch(InvalidCastException) { }
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is mProductos);
            mProductos obj = new mProductos();

            if (frm != null)
                MessageBox.Show("Esa ventana ya esta abierta.");
            else
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is mClientes);
            mClientes obj = new mClientes();
            
            if(frm != null)
                MessageBox.Show("Esa ventana ya esta abierta.");
            else
            {
                obj.MdiParent = this;
                obj.Show();
            }
                      
        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is mSuplidores);
            mSuplidores obj = new mSuplidores();

            if (frm != null)
                MessageBox.Show("Esa ventana ya esta abierta.");
            else
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is mDepartamentos);
            mDepartamentos obj = new mDepartamentos();

            if (frm != null)
                MessageBox.Show("Esa ventana ya esta abierta.");
            else
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is mUnidades);
            mUnidades obj = new mUnidades();

            if (frm != null)
                MessageBox.Show("Esa ventana ya esta abierta.");
            else
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is mUsuario);
            mUsuario obj = new mUsuario();

            if (frm != null)
                MessageBox.Show("Esa ventana ya esta abierta.");
            else
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is mFactura);
            mFactura obj = new mFactura();

            if (frm != null)
                MessageBox.Show("Esa ventana ya esta abierta.");
            else
            {
                obj.RecibirUsuario(nomusuario, codusuario);
                obj.MdiParent = this;
                obj.Show();
            }
            
        }

        private void Menu_MdiChildActivate(object sender, EventArgs e)
        {
            if(ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;

                botonConsultar.Enabled = obj.PuedeConsultar;
                botonGuardar.Enabled = obj.PuedeSalvar;
                botonImprimir.Enabled = obj.PuedeImprimir;
                botonEliminar.Enabled = obj.PuedeEliminar;
            }
            else
            {
                botonConsultar.Enabled = true;
                botonGuardar.Enabled = true;
                botonImprimir.Enabled = true;
                botonEliminar.Enabled = true;
            }

            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Consultas);

            if (frm == null)
            {
                botonImprimir.Enabled = true;
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;

                obj.Guardar();
            }
        }

        private void botonImprimir_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;

                obj.Imprimir();
            }
        }

        private void botonConsultar_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;

                obj.Consultar();
            }
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;

                obj.Eliminar();
            }
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cClientes obj = new cClientes();

             obj.MdiParent = this;
             obj.Show();
        }

        private void departamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cDepartamentos obj = new cDepartamentos();

            obj.MdiParent = this;
            obj.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cProductos obj = new cProductos();

            obj.MdiParent = this;
            obj.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cSuplidores obj = new cSuplidores();

            obj.MdiParent = this;
            obj.Show();
        }

        private void unidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUnidades obj = new cUnidades();

            obj.MdiParent = this;
            obj.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUsuarios obj = new cUsuarios();

            obj.MdiParent = this;
            obj.Show();
        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cFactura obj = new cFactura();

            obj.MdiParent = this;
            obj.Show();
        }
        private void ventasEntreFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cVentasEntreFechas vef = new cVentasEntreFechas();
            vef.MdiParent = this;
            vef.Show();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
