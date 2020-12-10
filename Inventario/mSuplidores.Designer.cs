namespace Inventario
{
    partial class mSuplidores
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
            this.label2 = new Utilidades.label(this.components);
            this.label5 = new Utilidades.label(this.components);
            this.label6 = new Utilidades.label(this.components);
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.bDireccion = new Utilidades.textbox(this.components);
            this.bEmail = new Utilidades.textbox(this.components);
            this.bNombre = new Utilidades.textbox(this.components);
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
            this.panel1.Location = new System.Drawing.Point(640, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bNombre);
            this.panel2.Controls.Add(this.bEmail);
            this.panel2.Controls.Add(this.bDireccion);
            this.panel2.Controls.Add(this.ckEstado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bCodigo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Size = new System.Drawing.Size(640, 434);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Codigo:";
            // 
            // bCodigo
            // 
            this.bCodigo.BackColor = System.Drawing.Color.DarkRed;
            this.bCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCodigo.ForeColor = System.Drawing.Color.White;
            this.bCodigo.Location = new System.Drawing.Point(149, 95);
            this.bCodigo.Name = "bCodigo";
            this.bCodigo.Size = new System.Drawing.Size(63, 25);
            this.bCodigo.TabIndex = 0;
            this.bCodigo.Validar = true;
            this.bCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.bCodigo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Direccion: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombre:";
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckEstado.Location = new System.Drawing.Point(85, 254);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(73, 24);
            this.ckEstado.TabIndex = 3;
            this.ckEstado.Text = "Estado";
            this.ckEstado.UseVisualStyleBackColor = true;
            // 
            // bDireccion
            // 
            this.bDireccion.BackColor = System.Drawing.Color.DarkRed;
            this.bDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDireccion.ForeColor = System.Drawing.Color.White;
            this.bDireccion.Location = new System.Drawing.Point(169, 302);
            this.bDireccion.Name = "bDireccion";
            this.bDireccion.Size = new System.Drawing.Size(200, 25);
            this.bDireccion.TabIndex = 4;
            this.bDireccion.Validar = true;
            // 
            // bEmail
            // 
            this.bEmail.BackColor = System.Drawing.Color.DarkRed;
            this.bEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEmail.ForeColor = System.Drawing.Color.White;
            this.bEmail.Location = new System.Drawing.Point(137, 206);
            this.bEmail.Name = "bEmail";
            this.bEmail.Size = new System.Drawing.Size(183, 25);
            this.bEmail.TabIndex = 2;
            this.bEmail.Validar = true;
            // 
            // bNombre
            // 
            this.bNombre.BackColor = System.Drawing.Color.DarkRed;
            this.bNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNombre.ForeColor = System.Drawing.Color.White;
            this.bNombre.Location = new System.Drawing.Point(157, 149);
            this.bNombre.Name = "bNombre";
            this.bNombre.Size = new System.Drawing.Size(163, 25);
            this.bNombre.TabIndex = 1;
            this.bNombre.Validar = true;
            // 
            // mSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 434);
            this.Name = "mSuplidores";
            this.Text = "Registro Suplidores";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Utilidades.label label3;
        private Utilidades.textbox bCodigo;
        private Utilidades.label label6;
        private Utilidades.label label5;
        private Utilidades.label label2;
        private Utilidades.textbox bNombre;
        private Utilidades.textbox bEmail;
        private Utilidades.textbox bDireccion;
        private System.Windows.Forms.CheckBox ckEstado;
    }
}