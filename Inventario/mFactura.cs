using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Inventario
{
    public partial class mFactura : Mantenimientos
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

        public static Double total;
        public mFactura()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            bNumero_Validating(null, null);
        }

        private void bNumero_Validating(object sender, CancelEventArgs e)
        {
            string numfac = "0";
            string cmd = string.Empty;

            cmd = string.Format("exec NumeroFactura '{0}'", numfac);
            DS = Utilidades.utilidades.ConectarSQL(cmd);

            numfac = DS.Tables[0].Rows[0]["numfac"].ToString().Trim();
                
            bNumerodetalle.Text = numfac;
            bNumero.Text = numfac;

            bFecha.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void bCodcli_Validating(object sender, CancelEventArgs e)
        {
            DS = Utilidades.utilidades.ConectarSQL("SELECT * FROM Clientes WHERE codCliente='" + bCodcli.Text.Trim() + "'");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                bnCliente.Text = DS.Tables[0].Rows[0]["nCliente"].ToString().Trim();
                bEmail.Text = DS.Tables[0].Rows[0]["Email"].ToString().Trim();
                codProducto.Focus();
            }
            else
            {
                bnCliente.Text = "";
                bEmail.Text = "";
                MessageBox.Show("Cliente invalido");
                return;
            }
        }

        private void codProducto_Validating(object sender, CancelEventArgs e)
        {
            double precio = 0;
            DS = Utilidades.utilidades.ConectarSQL("SELECT * FROM Productos WHERE codProducto='" + codProducto.Text.Trim() + "'");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                precio = Convert.ToDouble(DS.Tables[0].Rows[0]["Preventa"].ToString().Trim());
            }
            bPrecio.Text = precio.ToString();
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            if (Utilidades.utilidades.ValidaForm(this, errorProvider))
                return;

            for(int i=0; i<dataDetalle.Rows.Count; i++)
            {
                if(codProducto.Text.Trim() == dataDetalle.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Ya agregaste ese producto, puedes modificarlo seleccionando la fila en la tabla!");
                    return;
                }
            }

            DS = Utilidades.utilidades.ConectarSQL("SELECT * FROM Productos WHERE codProducto='" + codProducto.Text.Trim() + "'");
            string nombre = string.Empty;
            int existencia,puntoreo = 0;

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                nombre = DS.Tables[0].Rows[0]["nProducto"].ToString().Trim();
                existencia = Convert.ToInt32(DS.Tables[0].Rows[0]["ExiProducto"].ToString().Trim());
                puntoreo = Convert.ToInt32(DS.Tables[0].Rows[0]["Punreo"].ToString().Trim());
            }
            else
            {
                MessageBox.Show("Producto invalido!");
                return;
            }

            if (existencia < Convert.ToInt32(bCantidad.Text.Trim()))
            {
                MessageBox.Show("No tenenemos esa cantidad en ese producto!");
                bCantidad.Text = "";
                bPrecio.Text = "";
                return;
            }

            if (existencia <= puntoreo)
                DS = Utilidades.utilidades.ConectarSQL("UPDATE Productos set ExiProducto=ExiProducto+100 WHERE codProducto='" + codProducto.Text.Trim() + "'");

            
            if (string.IsNullOrEmpty(bNumerodetalle.Text.Trim()) || string.IsNullOrEmpty(codProducto.Text.Trim()) || string.IsNullOrEmpty(bCantidad.Text.Trim()) || string.IsNullOrEmpty(bPrecio.Text.Trim()))
                MessageBox.Show("Debe rellenar el detalle!");
            else
            {
                DataGridViewRow rows = new DataGridViewRow();
                rows.CreateCells(dataDetalle);

                rows.Cells[0].Value = codProducto.Text.Trim();
                rows.Cells[1].Value = nombre;
                rows.Cells[2].Value = bCantidad.Text.Trim();
                rows.Cells[3].Value = bPrecio.Text.Trim();
                rows.Cells[4].Value = (Convert.ToDouble(bPrecio.Text.Trim()) * Convert.ToDouble(bCantidad.Text.Trim())).ToString("N2");

                dataDetalle.Rows.Add(rows);

                Total.Text = (total += Convert.ToDouble(rows.Cells[4].Value)).ToString("N2");
                LimpiarDetalle();
            }
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            DS = Utilidades.utilidades.ConectarSQL("SELECT * FROM Productos WHERE codProducto='" + codProducto.Text.Trim() + "'");
            int existencia = 0;

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                existencia = Convert.ToInt32(DS.Tables[0].Rows[0]["ExiProducto"].ToString().Trim());

            if (existencia < Convert.ToInt32(bCantidad.Text.Trim()))
            {
                MessageBox.Show("No tenenemos esa cantidad en ese producto!");
                bCantidad.Text = "";
                bPrecio.Text = "";
                return;
            }
            if (codProducto.Text.Trim() != dataDetalle.CurrentRow.Cells[0].Value.ToString())
            {
                MessageBox.Show("El codigo del producto debe ser igual a que se quiere modificar!");
                codProducto.Focus();
                return;
            }
            else
            {
                total = total - Convert.ToDouble(dataDetalle.CurrentRow.Cells[4].Value);
                dataDetalle.CurrentRow.Selected = false;
                bModificar.Enabled = false;
                dataDetalle.CurrentRow.Cells[0].Value = codProducto.Text.Trim();
                dataDetalle.CurrentRow.Cells[2].Value = bCantidad.Text.Trim();
                dataDetalle.CurrentRow.Cells[3].Value = bPrecio.Text.Trim();
                dataDetalle.CurrentRow.Cells[4].Value = (Convert.ToDouble(bPrecio.Text.Trim()) * Convert.ToDouble(bCantidad.Text.Trim())).ToString("N2");
                Total.Text = (total += Convert.ToDouble(dataDetalle.CurrentRow.Cells[4].Value)).ToString("N2");
                LimpiarDetalle();
            }    
        }

        public override void Guardar()
        {
            if (Utilidades.utilidades.ValidaForm(this, errorProvider))
                return;

            string cmd = string.Empty;

            if(dataDetalle.Rows.Count == 0)
            {
                MessageBox.Show("No has agregado ningun producto!");
                return;
            }

            cmd = string.Format("exec ActualizaFactura '{0}','{1}','{2}','{3}'",
                bNumero.Text.Trim(), bFecha.Text.Trim(), bCodcli.Text.Trim(), ckEstado.Checked);

            DS = Utilidades.utilidades.ConectarSQL(cmd);
            if (Utilidades.utilidades.dsTieneDatos(DS) == false)
            {
                MessageBox.Show("Error registrando factura");
                return;
            }

            //Aqui rebaja la existencia del producto en el procedimiento almacenado
            for (int i = 0; i < dataDetalle.Rows.Count; i++)
            {
                cmd = string.Format("exec Actualizadetalles '{0}','{1}','{2}','{3}'",
                    bNumero.Text.Trim(), dataDetalle.Rows[i].Cells[0].Value.ToString(), dataDetalle.Rows[i].Cells[2].Value.ToString(), dataDetalle.Rows[i].Cells[3].Value.ToString());

                DS = Utilidades.utilidades.ConectarSQL(cmd);
                if (Utilidades.utilidades.dsTieneDatos(DS) == false)
                {
                    MessageBox.Show("Error registrando factura");
                    return;
                }
            }

            Limpiar();
            dataDetalle.Rows.Clear();
            cmd = string.Format("exec DatosFactura '{0}'", bNumero.Text.Trim());
            DS = Utilidades.utilidades.ConectarSQL(cmd);
            if (Utilidades.utilidades.dsTieneDatos(DS))
            {
                ImprimirFactura obj = new ImprimirFactura();
                obj.MostrarDatos(DS);
                obj.Show();
            }
            bNumero_Validating(null, null);
            total = 0;
        }

        public override void Limpiar()
        {
            base.Limpiar();

            bEmail.Text = "";
            bCodcli.Text = "";
            bCantidad.Text = "";
            codProducto.Text = "";
            bnCliente.Text = "";
            bPrecio.Text = "";
            Total.Text = "";
        }

        public override void Consultar()
        {
            ProductosDisponibles obj = new ProductosDisponibles();
            if (obj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int pos = obj.dataProductos.CurrentCell.RowIndex;

                codProducto.Text = obj.dataProductos.Rows[pos].Cells[0].Value.ToString().Trim();

                codProducto_Validating(null, null);
                bCantidad.Focus();
            }
            obj.Dispose();
        }
        public override void Eliminar()
        {
            total = total - Convert.ToDouble(dataDetalle.CurrentRow.Cells[4].Value);
            Total.Text = total.ToString("N2");
            LimpiarDetalle();
            dataDetalle.Rows.Remove(dataDetalle.CurrentRow);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codProducto.Text = dataDetalle.CurrentRow.Cells[0].Value.ToString();
            bCantidad.Text = dataDetalle.CurrentRow.Cells[2].Value.ToString();
            bPrecio.Text = dataDetalle.CurrentRow.Cells[3].Value.ToString();
            bModificar.Enabled = true;
            codProducto_Validating(null,null);
        }

        private void LimpiarDetalle()
        {
            codProducto.Text = "";
            bCantidad.Text = "";
            bPrecio.Text = "";
            codProducto.Focus();
        }
    }
}
