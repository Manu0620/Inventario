namespace Inventario
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.bSeleccionar = new Utilidades.boton(this.components);
            this.bImprimir = new Utilidades.boton(this.components);
            this.bBuscar = new Utilidades.boton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte
            // 
            this.reporte.ServerReport.BearerToken = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bBuscar);
            this.panel1.Controls.Add(this.bImprimir);
            this.panel1.Controls.Add(this.bSeleccionar);
            this.panel1.Location = new System.Drawing.Point(675, 0);
            this.panel1.Controls.SetChildIndex(this.bSeleccionar, 0);
            this.panel1.Controls.SetChildIndex(this.bImprimir, 0);
            this.panel1.Controls.SetChildIndex(this.bBuscar, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(675, 434);
            // 
            // bSeleccionar
            // 
            this.bSeleccionar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.bSeleccionar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSeleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionar.ForeColor = System.Drawing.Color.Transparent;
            this.bSeleccionar.Location = new System.Drawing.Point(0, 332);
            this.bSeleccionar.Name = "bSeleccionar";
            this.bSeleccionar.Size = new System.Drawing.Size(144, 51);
            this.bSeleccionar.TabIndex = 1;
            this.bSeleccionar.Text = "Seleccionar";
            this.bSeleccionar.UseVisualStyleBackColor = true;
            this.bSeleccionar.UseWaitCursor = true;
            // 
            // bImprimir
            // 
            this.bImprimir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.bImprimir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bImprimir.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bImprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImprimir.ForeColor = System.Drawing.Color.Transparent;
            this.bImprimir.Location = new System.Drawing.Point(0, 281);
            this.bImprimir.Name = "bImprimir";
            this.bImprimir.Size = new System.Drawing.Size(144, 51);
            this.bImprimir.TabIndex = 2;
            this.bImprimir.Text = "Imprimir";
            this.bImprimir.UseVisualStyleBackColor = true;
            this.bImprimir.UseWaitCursor = true;
            this.bImprimir.Click += new System.EventHandler(this.bImprimir_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.bBuscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bBuscar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscar.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.ForeColor = System.Drawing.Color.Transparent;
            this.bBuscar.Location = new System.Drawing.Point(0, 230);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(144, 51);
            this.bBuscar.TabIndex = 3;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.UseWaitCursor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 434);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas";
            this.PuedeImprimir = true;
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Utilidades.boton bBuscar;
        public Utilidades.boton bImprimir;
        public Utilidades.boton bSeleccionar;
    }
}