using System;
using System.Windows.Forms;
using System.Data;

namespace Inventario
{
    public partial class TareaGV : Form
    {
        public TareaGV()
        {
            InitializeComponent();
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (Utilidades.utilidades.ValidaForm(this, errorProvider1))
                return;

            DataGridViewRow rows = new DataGridViewRow();
            rows.CreateCells(GV);

            rows.Cells[0].Value = bDato1.Text.Trim();
            rows.Cells[1].Value = bDato2.Text.Trim();
            rows.Cells[2].Value = bDato3.Text.Trim();

            GV.Rows.Add(rows);
            bDato1.Text = "";
            bDato2.Text = "";
            bDato3.Text = "";
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            GV.Rows.Remove(GV.CurrentRow);
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            if (Utilidades.utilidades.ValidaForm(this, errorProvider1))
                return;

            if (GV.CurrentRow.Selected == false)
                MessageBox.Show("Debe seleccionar una fila!");
            else
            {
                GV.CurrentRow.Cells[0].Value = bDato1.Text.Trim();
                GV.CurrentRow.Cells[1].Value = bDato2.Text.Trim();
                GV.CurrentRow.Cells[2].Value = bDato3.Text.Trim();

                bDato1.Text = "";
                bDato2.Text = "";
                bDato3.Text = "";
            }
        }
    }
}
