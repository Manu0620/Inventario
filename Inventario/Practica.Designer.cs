namespace Inventario
{
    partial class Practica
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
            this.botonPersonalizado1 = new Utilidades.BotonPersonalizado();
            this.SuspendLayout();
            // 
            // botonPersonalizado1
            // 
            this.botonPersonalizado1.Angle = 126F;
            this.botonPersonalizado1.BorderRadius = 20;
            this.botonPersonalizado1.Color1 = System.Drawing.Color.MidnightBlue;
            this.botonPersonalizado1.Color2 = System.Drawing.Color.Red;
            this.botonPersonalizado1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalizado1.ForeColor = System.Drawing.Color.White;
            this.botonPersonalizado1.Location = new System.Drawing.Point(141, 101);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(190, 77);
            this.botonPersonalizado1.TabIndex = 0;
            // 
            // Practica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 301);
            this.Controls.Add(this.botonPersonalizado1);
            this.Name = "Practica";
            this.Text = "Practica";
            this.ResumeLayout(false);

        }

        #endregion

        private Utilidades.BotonPersonalizado botonPersonalizado1;
    }
}