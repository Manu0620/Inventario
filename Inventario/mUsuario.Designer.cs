namespace Inventario
{
    partial class mUsuario
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
            this.label3 = new Utilidades.label(this.components);
            this.bCodigo = new Utilidades.textbox(this.components);
            this.label1 = new Utilidades.label(this.components);
            this.label2 = new Utilidades.label(this.components);
            this.label4 = new Utilidades.label(this.components);
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.bNombre = new Utilidades.textbox(this.components);
            this.bPassword = new Utilidades.textbox(this.components);
            this.bNivel = new Utilidades.textbox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reporte
            // 
            this.reporte.ServerReport.BearerToken = null;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(657, 0);
            this.panel1.Size = new System.Drawing.Size(144, 436);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.bNivel);
            this.panel2.Controls.Add(this.bPassword);
            this.panel2.Controls.Add(this.bNombre);
            this.panel2.Controls.Add(this.ckEstado);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bCodigo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Size = new System.Drawing.Size(657, 436);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codigo: ";
            // 
            // bCodigo
            // 
            this.bCodigo.BackColor = System.Drawing.Color.DarkRed;
            this.bCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCodigo.ForeColor = System.Drawing.Color.White;
            this.bCodigo.Location = new System.Drawing.Point(146, 82);
            this.bCodigo.Name = "bCodigo";
            this.bCodigo.Size = new System.Drawing.Size(80, 25);
            this.bCodigo.TabIndex = 0;
            this.bCodigo.Validar = true;
            this.bCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.bCodigo_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nivel (1-5): ";
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckEstado.Location = new System.Drawing.Point(87, 266);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(73, 24);
            this.ckEstado.TabIndex = 19;
            this.ckEstado.Text = "Estado";
            this.ckEstado.UseVisualStyleBackColor = true;
            // 
            // bNombre
            // 
            this.bNombre.BackColor = System.Drawing.Color.DarkRed;
            this.bNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNombre.ForeColor = System.Drawing.Color.White;
            this.bNombre.Location = new System.Drawing.Point(163, 147);
            this.bNombre.Name = "bNombre";
            this.bNombre.Size = new System.Drawing.Size(175, 25);
            this.bNombre.TabIndex = 1;
            this.bNombre.Validar = true;
            // 
            // bPassword
            // 
            this.bPassword.BackColor = System.Drawing.Color.DarkRed;
            this.bPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPassword.ForeColor = System.Drawing.Color.White;
            this.bPassword.Location = new System.Drawing.Point(163, 207);
            this.bPassword.Name = "bPassword";
            this.bPassword.PasswordChar = '•';
            this.bPassword.Size = new System.Drawing.Size(219, 25);
            this.bPassword.TabIndex = 2;
            this.bPassword.UseSystemPasswordChar = true;
            this.bPassword.Validar = true;
            // 
            // bNivel
            // 
            this.bNivel.BackColor = System.Drawing.Color.DarkRed;
            this.bNivel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNivel.ForeColor = System.Drawing.Color.White;
            this.bNivel.Location = new System.Drawing.Point(163, 334);
            this.bNivel.Name = "bNivel";
            this.bNivel.Size = new System.Drawing.Size(94, 25);
            this.bNivel.TabIndex = 3;
            this.bNivel.Validar = true;
            // 
            // mUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 436);
            this.Name = "mUsuario";
            this.Text = "mUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilidades.label label3;
        private Utilidades.label label4;
        private Utilidades.label label2;
        private Utilidades.label label1;
        private Utilidades.textbox bCodigo;
        private Utilidades.textbox bNivel;
        private Utilidades.textbox bPassword;
        private Utilidades.textbox bNombre;
        private System.Windows.Forms.CheckBox ckEstado;
    }
}