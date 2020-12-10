namespace Inventario
{
    partial class Acerca
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
            this.label2 = new Utilidades.label(this.components);
            this.label3 = new Utilidades.label(this.components);
            this.label1 = new Utilidades.label(this.components);
            this.panel1 = new Utilidades.panel(this.components);
            this.Cerrar = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(174, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manuel A. Madera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(165, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "© All rights reserved";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(149, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application created by: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 282);
            this.panel1.TabIndex = 3;
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
            this.Cerrar.Location = new System.Drawing.Point(501, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(35, 44);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 5;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Acerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 282);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Acerca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de..";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utilidades.label label2;
        private Utilidades.label label3;
        private Utilidades.label label1;
        private Utilidades.panel panel1;
        private FontAwesome.Sharp.IconPictureBox Cerrar;
    }
}