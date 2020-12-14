namespace Inventario
{
    partial class ProductosDisponibles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new Utilidades.label(this.components);
            this.bSeleccionar = new Utilidades.boton(this.components);
            this.dataProductos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExiProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cerrar = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bSeleccionar);
            this.panel1.Controls.Add(this.dataProductos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 449);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(111, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "Productos Disponibles";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.bSeleccionar.FlatAppearance.BorderSize = 2;
            this.bSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.bSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSeleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionar.ForeColor = System.Drawing.Color.White;
            this.bSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSeleccionar.Location = new System.Drawing.Point(290, 394);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(179, 43);
            this.bSeleccionar.TabIndex = 6;
            this.bSeleccionar.Text = "Seleccionar Producto";
            this.bSeleccionar.UseVisualStyleBackColor = true;
            this.bSeleccionar.Click += new System.EventHandler(this.bSeleccionar_Click);
            // 
            // dataProductos
            // 
            this.dataProductos.AllowUserToAddRows = false;
            this.dataProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.dataProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataProductos.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.ExiProducto,
            this.Column4});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataProductos.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataProductos.EnableHeadersVisualStyles = false;
            this.dataProductos.GridColor = System.Drawing.Color.Lavender;
            this.dataProductos.Location = new System.Drawing.Point(34, 63);
            this.dataProductos.Name = "dataProductos";
            this.dataProductos.ReadOnly = true;
            this.dataProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dataProductos.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataProductos.Size = new System.Drawing.Size(680, 317);
            this.dataProductos.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo.DataPropertyName = "codProducto";
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Transparent;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle15;
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 76;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "nProducto";
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 83;
            // 
            // ExiProducto
            // 
            this.ExiProducto.DataPropertyName = "ExiProducto";
            this.ExiProducto.HeaderText = "Existencia";
            this.ExiProducto.Name = "ExiProducto";
            this.ExiProducto.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Status";
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cerrar.ForeColor = System.Drawing.Color.DarkRed;
            this.Cerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Cerrar.IconColor = System.Drawing.Color.DarkRed;
            this.Cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Cerrar.IconSize = 35;
            this.Cerrar.Location = new System.Drawing.Point(703, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(35, 44);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 20;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // ProductosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 449);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductosDisponibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos Disponibles";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataProductos;
        private Utilidades.boton bSeleccionar;
        private Utilidades.label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExiProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private FontAwesome.Sharp.IconPictureBox Cerrar;
    }
}