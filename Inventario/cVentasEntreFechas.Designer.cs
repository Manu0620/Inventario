namespace Inventario
{
    partial class cVentasEntreFechas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new Utilidades.panel(this.components);
            this.bCliente = new Utilidades.textbox(this.components);
            this.label3 = new Utilidades.label(this.components);
            this.bFfinal = new Utilidades.textbox(this.components);
            this.label1 = new Utilidades.label(this.components);
            this.bFinicial = new Utilidades.textbox(this.components);
            this.label2 = new Utilidades.label(this.components);
            this.dataVentas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new Utilidades.label(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // bImprimir
            // 
            this.bImprimir.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bImprimir.Location = new System.Drawing.Point(0, 282);
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bSeleccionar.Location = new System.Drawing.Point(0, 333);
            // 
            // reporte
            // 
            this.reporte.ServerReport.BearerToken = null;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(719, 0);
            this.panel1.Size = new System.Drawing.Size(144, 435);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataVentas);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Size = new System.Drawing.Size(719, 435);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.bCliente);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.bFfinal);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bFinicial);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 110);
            this.panel3.TabIndex = 4;
            // 
            // bCliente
            // 
            this.bCliente.BackColor = System.Drawing.Color.DarkRed;
            this.bCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCliente.ForeColor = System.Drawing.Color.White;
            this.bCliente.Location = new System.Drawing.Point(524, 53);
            this.bCliente.Name = "bCliente";
            this.bCliente.Size = new System.Drawing.Size(121, 25);
            this.bCliente.TabIndex = 7;
            this.bCliente.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bFfinal
            // 
            this.bFfinal.BackColor = System.Drawing.Color.DarkRed;
            this.bFfinal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFfinal.ForeColor = System.Drawing.Color.White;
            this.bFfinal.Location = new System.Drawing.Point(300, 53);
            this.bFfinal.Name = "bFfinal";
            this.bFfinal.Size = new System.Drawing.Size(121, 25);
            this.bFfinal.TabIndex = 5;
            this.bFfinal.Validar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hasta:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bFinicial
            // 
            this.bFinicial.BackColor = System.Drawing.Color.DarkRed;
            this.bFinicial.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFinicial.ForeColor = System.Drawing.Color.White;
            this.bFinicial.Location = new System.Drawing.Point(110, 53);
            this.bFinicial.Name = "bFinicial";
            this.bFinicial.Size = new System.Drawing.Size(116, 25);
            this.bFinicial.TabIndex = 0;
            this.bFinicial.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Desde:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataVentas
            // 
            this.dataVentas.AllowUserToAddRows = false;
            this.dataVentas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataVentas.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Email,
            this.preven});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataVentas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataVentas.EnableHeadersVisualStyles = false;
            this.dataVentas.GridColor = System.Drawing.Color.Lavender;
            this.dataVentas.Location = new System.Drawing.Point(0, 110);
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.ReadOnly = true;
            this.dataVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataVentas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataVentas.Size = new System.Drawing.Size(719, 325);
            this.dataVentas.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo.DataPropertyName = "numfac";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Numero";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 83;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "fecfac";
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 68;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "status";
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 74;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "nCliente";
            this.Column3.HeaderText = "Cliente";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 74;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 65;
            // 
            // preven
            // 
            this.preven.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preven.DataPropertyName = "total";
            this.preven.HeaderText = "Total";
            this.preven.Name = "preven";
            this.preven.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Formato de fecha: 20201214";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cVentasEntreFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 435);
            this.Name = "cVentasEntreFechas";
            this.Text = "Ventas entre fecha";
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Utilidades.panel panel3;
        private Utilidades.textbox bFinicial;
        private Utilidades.label label2;
        public System.Windows.Forms.DataGridView dataVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn preven;
        private Utilidades.textbox bFfinal;
        private Utilidades.label label1;
        private Utilidades.textbox bCliente;
        private Utilidades.label label3;
        private Utilidades.label label4;
    }
}