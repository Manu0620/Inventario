namespace Inventario
{
    partial class Bienvenido
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bAñadir = new Utilidades.boton(this.components);
            this.Bienvenida = new Utilidades.label(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.bAñadir);
            this.panel1.Controls.Add(this.Bienvenida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 232);
            this.panel1.TabIndex = 0;
            // 
            // bAñadir
            // 
            this.bAñadir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAñadir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.bAñadir.FlatAppearance.BorderSize = 2;
            this.bAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.bAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAñadir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAñadir.ForeColor = System.Drawing.Color.White;
            this.bAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAñadir.Location = new System.Drawing.Point(226, 150);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(114, 43);
            this.bAñadir.TabIndex = 5;
            this.bAñadir.Text = "OK";
            this.bAñadir.UseVisualStyleBackColor = true;
            // 
            // Bienvenida
            // 
            this.Bienvenida.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenida.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Bienvenida.Location = new System.Drawing.Point(3, 62);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(561, 30);
            this.Bienvenida.TabIndex = 1;
            this.Bienvenida.Text = "Bienvenido/a";
            this.Bienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 232);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenido";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Utilidades.label Bienvenida;
        private Utilidades.boton bAñadir;
    }
}