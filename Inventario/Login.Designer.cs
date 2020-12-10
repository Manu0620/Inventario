namespace Inventario
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new Utilidades.panel(this.components);
            this.botonPersonalizado1 = new Utilidades.BotonPersonalizado();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.bPassword = new Utilidades.textbox(this.components);
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.Advertencia = new Utilidades.label(this.components);
            this.label3 = new Utilidades.label(this.components);
            this.label1 = new Utilidades.label(this.components);
            this.bCodigo = new Utilidades.textbox(this.components);
            this.label2 = new Utilidades.label(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.botonPersonalizado1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.bPassword);
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.Advertencia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bCodigo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 349);
            this.panel1.TabIndex = 0;
            // 
            // botonPersonalizado1
            // 
            this.botonPersonalizado1.Angle = 129F;
            this.botonPersonalizado1.BorderRadius = 20;
            this.botonPersonalizado1.Color1 = System.Drawing.Color.MidnightBlue;
            this.botonPersonalizado1.Color2 = System.Drawing.Color.Red;
            this.botonPersonalizado1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPersonalizado1.ForeColor = System.Drawing.Color.White;
            this.botonPersonalizado1.Location = new System.Drawing.Point(107, 269);
            this.botonPersonalizado1.Name = "botonPersonalizado1";
            this.botonPersonalizado1.Size = new System.Drawing.Size(143, 48);
            this.botonPersonalizado1.TabIndex = 15;
            this.botonPersonalizado1.Click += new System.EventHandler(this.bIngresar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 335);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 14);
            this.panel2.TabIndex = 14;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkRed;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 56;
            this.iconPictureBox1.Location = new System.Drawing.Point(97, 33);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(57, 56);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 13;
            this.iconPictureBox1.TabStop = false;
            // 
            // bPassword
            // 
            this.bPassword.BackColor = System.Drawing.Color.MidnightBlue;
            this.bPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPassword.ForeColor = System.Drawing.Color.White;
            this.bPassword.Location = new System.Drawing.Point(51, 198);
            this.bPassword.Name = "bPassword";
            this.bPassword.Size = new System.Drawing.Size(253, 28);
            this.bPassword.TabIndex = 1;
            this.bPassword.Text = "123456789";
            this.bPassword.UseSystemPasswordChar = true;
            this.bPassword.Validar = true;
            // 
            // Cerrar
            // 
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(329, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(22, 23);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 11;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Advertencia
            // 
            this.Advertencia.AutoSize = true;
            this.Advertencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advertencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Advertencia.Image = ((System.Drawing.Image)(resources.GetObject("Advertencia.Image")));
            this.Advertencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Advertencia.Location = new System.Drawing.Point(126, 229);
            this.Advertencia.Name = "Advertencia";
            this.Advertencia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Advertencia.Size = new System.Drawing.Size(28, 17);
            this.Advertencia.TabIndex = 10;
            this.Advertencia.Text = "     ";
            this.Advertencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Advertencia.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(57, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bCodigo
            // 
            this.bCodigo.BackColor = System.Drawing.Color.MidnightBlue;
            this.bCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCodigo.ForeColor = System.Drawing.Color.White;
            this.bCodigo.Location = new System.Drawing.Point(51, 126);
            this.bCodigo.Name = "bCodigo";
            this.bCodigo.Size = new System.Drawing.Size(253, 28);
            this.bCodigo.TabIndex = 0;
            this.bCodigo.Text = "1";
            this.bCodigo.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(57, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 349);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utilidades.panel panel1;
        private Utilidades.label label2;
        private Utilidades.textbox bCodigo;
        private Utilidades.label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Utilidades.label Advertencia;
        private Utilidades.label label1;
        private System.Windows.Forms.PictureBox Cerrar;
        private Utilidades.textbox bPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Utilidades.BotonPersonalizado botonPersonalizado1;
    }
}