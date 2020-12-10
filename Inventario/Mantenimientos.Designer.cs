namespace Inventario
{
    partial class Mantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimientos));
            this.bEliminar = new Utilidades.boton(this.components);
            this.bConsultar = new Utilidades.boton(this.components);
            this.bGuardar = new Utilidades.boton(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // reporte
            // 
            this.reporte.ServerReport.BearerToken = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bGuardar);
            this.panel1.Controls.Add(this.bConsultar);
            this.panel1.Controls.Add(this.bEliminar);
            this.panel1.Location = new System.Drawing.Point(649, 0);
            this.panel1.Controls.SetChildIndex(this.bEliminar, 0);
            this.panel1.Controls.SetChildIndex(this.bConsultar, 0);
            this.panel1.Controls.SetChildIndex(this.bGuardar, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Size = new System.Drawing.Size(649, 434);
            // 
            // bEliminar
            // 
            this.bEliminar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bEliminar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.ForeColor = System.Drawing.Color.White;
            this.bEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEliminar.Location = new System.Drawing.Point(0, 332);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(144, 51);
            this.bEliminar.TabIndex = 1;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bConsultar
            // 
            this.bConsultar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bConsultar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bConsultar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bConsultar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConsultar.ForeColor = System.Drawing.Color.White;
            this.bConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bConsultar.Location = new System.Drawing.Point(0, 281);
            this.bConsultar.Name = "bConsultar";
            this.bConsultar.Size = new System.Drawing.Size(144, 51);
            this.bConsultar.TabIndex = 2;
            this.bConsultar.Text = "Consultar";
            this.bConsultar.UseVisualStyleBackColor = true;
            this.bConsultar.Click += new System.EventHandler(this.bConsultar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bGuardar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGuardar.ForeColor = System.Drawing.Color.White;
            this.bGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bGuardar.Location = new System.Drawing.Point(0, 230);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(144, 51);
            this.bGuardar.TabIndex = 3;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 420);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 14);
            this.panel3.TabIndex = 36;
            // 
            // Mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 434);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mantenimientos";
            this.PuedeConsultar = true;
            this.PuedeEliminar = true;
            this.PuedeSalvar = true;
            this.Text = "Mantenimientos";
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Utilidades.boton bEliminar;
        private Utilidades.boton bGuardar;
        public System.Windows.Forms.ErrorProvider errorProvider;
        public Utilidades.boton bConsultar;
        private System.Windows.Forms.Panel panel3;
    }
}