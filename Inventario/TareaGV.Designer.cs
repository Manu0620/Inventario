namespace Inventario
{
    partial class TareaGV
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
            this.bAgregar = new Utilidades.boton(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new Utilidades.label(this.components);
            this.label1 = new Utilidades.label(this.components);
            this.label2 = new Utilidades.label(this.components);
            this.bDato1 = new Utilidades.textbox(this.components);
            this.bDato2 = new Utilidades.textbox(this.components);
            this.bDato3 = new Utilidades.textbox(this.components);
            this.GV = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bEliminar = new Utilidades.boton(this.components);
            this.bActualizar = new Utilidades.boton(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bAgregar
            // 
            this.bAgregar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bAgregar.FlatAppearance.BorderSize = 2;
            this.bAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.bAgregar.Location = new System.Drawing.Point(69, 86);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(144, 51);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "Agregar ";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.UseWaitCursor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bDato1);
            this.panel1.Controls.Add(this.bDato2);
            this.panel1.Controls.Add(this.bDato3);
            this.panel1.Controls.Add(this.GV);
            this.panel1.Controls.Add(this.bEliminar);
            this.panel1.Controls.Add(this.bActualizar);
            this.panel1.Controls.Add(this.bAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 434);
            this.panel1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(259, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dato 2:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(464, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dato 3:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dato 1:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bDato1
            // 
            this.bDato1.BackColor = System.Drawing.Color.MidnightBlue;
            this.bDato1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDato1.ForeColor = System.Drawing.Color.White;
            this.bDato1.Location = new System.Drawing.Point(113, 32);
            this.bDato1.Name = "bDato1";
            this.bDato1.Size = new System.Drawing.Size(100, 25);
            this.bDato1.TabIndex = 8;
            this.bDato1.Validar = true;
            // 
            // bDato2
            // 
            this.bDato2.BackColor = System.Drawing.Color.MidnightBlue;
            this.bDato2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDato2.ForeColor = System.Drawing.Color.White;
            this.bDato2.Location = new System.Drawing.Point(323, 32);
            this.bDato2.Name = "bDato2";
            this.bDato2.Size = new System.Drawing.Size(100, 25);
            this.bDato2.TabIndex = 7;
            this.bDato2.Validar = true;
            // 
            // bDato3
            // 
            this.bDato3.BackColor = System.Drawing.Color.MidnightBlue;
            this.bDato3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDato3.ForeColor = System.Drawing.Color.White;
            this.bDato3.Location = new System.Drawing.Point(528, 32);
            this.bDato3.Name = "bDato3";
            this.bDato3.Size = new System.Drawing.Size(100, 25);
            this.bDato3.TabIndex = 6;
            this.bDato3.Validar = true;
            // 
            // GV
            // 
            this.GV.AllowUserToAddRows = false;
            this.GV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.GV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GV.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GV.DefaultCellStyle = dataGridViewCellStyle4;
            this.GV.EnableHeadersVisualStyles = false;
            this.GV.GridColor = System.Drawing.Color.Lavender;
            this.GV.Location = new System.Drawing.Point(33, 160);
            this.GV.Name = "GV";
            this.GV.ReadOnly = true;
            this.GV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GV.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.GV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.GV.Size = new System.Drawing.Size(645, 246);
            this.GV.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Codigo.DataPropertyName = "codDepartamentos";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle3;
            this.Codigo.Frozen = true;
            this.Codigo.HeaderText = "Dato 1";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 71;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "desdep";
            this.Column1.HeaderText = "Dato 2";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 73;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "status";
            this.Column4.HeaderText = "Dato 3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // bEliminar
            // 
            this.bEliminar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bEliminar.FlatAppearance.BorderSize = 2;
            this.bEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.bEliminar.Location = new System.Drawing.Point(484, 86);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(144, 51);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.UseWaitCursor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bActualizar
            // 
            this.bActualizar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bActualizar.FlatAppearance.BorderSize = 2;
            this.bActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bActualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bActualizar.ForeColor = System.Drawing.Color.Transparent;
            this.bActualizar.Location = new System.Drawing.Point(279, 86);
            this.bActualizar.Name = "bActualizar";
            this.bActualizar.Size = new System.Drawing.Size(144, 51);
            this.bActualizar.TabIndex = 3;
            this.bActualizar.Text = "Actualizar";
            this.bActualizar.UseVisualStyleBackColor = true;
            this.bActualizar.UseWaitCursor = true;
            this.bActualizar.Click += new System.EventHandler(this.bActualizar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TareaGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 434);
            this.Controls.Add(this.panel1);
            this.Name = "TareaGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TareaGV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Utilidades.boton bAgregar;
        private System.Windows.Forms.Panel panel1;
        public Utilidades.boton bEliminar;
        public Utilidades.boton bActualizar;
        public System.Windows.Forms.DataGridView GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Utilidades.textbox bDato1;
        private Utilidades.textbox bDato2;
        private Utilidades.textbox bDato3;
        private Utilidades.label label3;
        private Utilidades.label label1;
        private Utilidades.label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}