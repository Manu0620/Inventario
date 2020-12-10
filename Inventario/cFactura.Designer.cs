namespace Inventario
{
    partial class cFactura
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
            this.bNumero = new Utilidades.textbox(this.components);
            this.label2 = new Utilidades.label(this.components);
            this.dataFactura = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preven = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFactura)).BeginInit();
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
            this.bSeleccionar.Click += new System.EventHandler(this.bSeleccionar_Click);
            // 
            // reporte
            // 
            this.reporte.ServerReport.BearerToken = null;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(940, 0);
            this.panel1.Size = new System.Drawing.Size(144, 435);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataFactura);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Size = new System.Drawing.Size(940, 435);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.bNumero);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 80);
            this.panel3.TabIndex = 3;
            // 
            // bNumero
            // 
            this.bNumero.BackColor = System.Drawing.Color.DarkRed;
            this.bNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumero.ForeColor = System.Drawing.Color.White;
            this.bNumero.Location = new System.Drawing.Point(147, 26);
            this.bNumero.Name = "bNumero";
            this.bNumero.Size = new System.Drawing.Size(100, 25);
            this.bNumero.TabIndex = 0;
            this.bNumero.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataFactura
            // 
            this.dataFactura.AllowUserToAddRows = false;
            this.dataFactura.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataFactura.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column3,
            this.codcli,
            this.Email,
            this.codProducto,
            this.nProducto,
            this.canven,
            this.preven});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFactura.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFactura.EnableHeadersVisualStyles = false;
            this.dataFactura.GridColor = System.Drawing.Color.Lavender;
            this.dataFactura.Location = new System.Drawing.Point(0, 80);
            this.dataFactura.Name = "dataFactura";
            this.dataFactura.ReadOnly = true;
            this.dataFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataFactura.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataFactura.Size = new System.Drawing.Size(940, 355);
            this.dataFactura.TabIndex = 4;
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
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "status";
            this.Column3.HeaderText = "Estado";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 74;
            // 
            // codcli
            // 
            this.codcli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codcli.DataPropertyName = "nCliente";
            this.codcli.HeaderText = "Cliente";
            this.codcli.Name = "codcli";
            this.codcli.ReadOnly = true;
            this.codcli.Width = 74;
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
            // codProducto
            // 
            this.codProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codProducto.DataPropertyName = "codProducto";
            this.codProducto.HeaderText = "Producto";
            this.codProducto.Name = "codProducto";
            this.codProducto.ReadOnly = true;
            this.codProducto.Width = 89;
            // 
            // nProducto
            // 
            this.nProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nProducto.DataPropertyName = "nProducto";
            this.nProducto.HeaderText = "Nombre";
            this.nProducto.Name = "nProducto";
            this.nProducto.ReadOnly = true;
            this.nProducto.Width = 83;
            // 
            // canven
            // 
            this.canven.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.canven.DataPropertyName = "canven";
            this.canven.HeaderText = "Cantidad";
            this.canven.Name = "canven";
            this.canven.ReadOnly = true;
            this.canven.Width = 87;
            // 
            // preven
            // 
            this.preven.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.preven.DataPropertyName = "preven";
            this.preven.HeaderText = "Precio";
            this.preven.Name = "preven";
            this.preven.ReadOnly = true;
            // 
            // cFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 435);
            this.Name = "cFactura";
            this.Text = "cFactura";
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Utilidades.panel panel3;
        private Utilidades.textbox bNumero;
        private Utilidades.label label2;
        public System.Windows.Forms.DataGridView dataFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn canven;
        private System.Windows.Forms.DataGridViewTextBoxColumn preven;
    }
}