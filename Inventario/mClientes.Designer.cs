namespace Inventario
{
    partial class mClientes
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
            this.bNombre = new Utilidades.textbox(this.components);
            this.bEmail = new Utilidades.textbox(this.components);
            this.bDireccion = new Utilidades.textbox(this.components);
            this.ckEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bConsultar
            // 
            this.bConsultar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            // 
            // reporte
            // 
            this.reporte.ServerReport.BearerToken = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckEstado);
            this.panel2.Controls.Add(this.bDireccion);
            this.panel2.Controls.Add(this.bEmail);
            this.panel2.Controls.Add(this.bNombre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bCodigo);
            this.panel2.Controls.Add(this.label3);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo: ";
            // 
            // bCodigo
            // 
            this.bCodigo.BackColor = System.Drawing.Color.DarkRed;
            this.bCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCodigo.ForeColor = System.Drawing.Color.White;
            this.bCodigo.Location = new System.Drawing.Point(141, 109);
            this.bCodigo.Name = "bCodigo";
            this.bCodigo.Size = new System.Drawing.Size(63, 25);
            this.bCodigo.TabIndex = 0;
            this.bCodigo.Validar = true;
            this.bCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.bCodigo_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Direccion: ";
            // 
            // bNombre
            // 
            this.bNombre.BackColor = System.Drawing.Color.DarkRed;
            this.bNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNombre.ForeColor = System.Drawing.Color.White;
            this.bNombre.Location = new System.Drawing.Point(141, 160);
            this.bNombre.Name = "bNombre";
            this.bNombre.Size = new System.Drawing.Size(164, 25);
            this.bNombre.TabIndex = 1;
            this.bNombre.Validar = true;
            // 
            // bEmail
            // 
            this.bEmail.BackColor = System.Drawing.Color.DarkRed;
            this.bEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEmail.ForeColor = System.Drawing.Color.White;
            this.bEmail.Location = new System.Drawing.Point(129, 212);
            this.bEmail.Name = "bEmail";
            this.bEmail.Size = new System.Drawing.Size(176, 25);
            this.bEmail.TabIndex = 2;
            this.bEmail.Validar = true;
            // 
            // bDireccion
            // 
            this.bDireccion.BackColor = System.Drawing.Color.DarkRed;
            this.bDireccion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDireccion.ForeColor = System.Drawing.Color.White;
            this.bDireccion.Location = new System.Drawing.Point(157, 268);
            this.bDireccion.Name = "bDireccion";
            this.bDireccion.Size = new System.Drawing.Size(228, 25);
            this.bDireccion.TabIndex = 3;
            this.bDireccion.Validar = true;
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckEstado.Location = new System.Drawing.Point(73, 324);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(73, 24);
            this.ckEstado.TabIndex = 18;
            this.ckEstado.Text = "Estado";
            this.ckEstado.UseVisualStyleBackColor = true;
            // 
            // mClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 434);
            this.Name = "mClientes";
            this.Text = "Registro Clientes";
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
        private System.Windows.Forms.CheckBox ckEstado;
        private Utilidades.textbox bDireccion;
        private Utilidades.textbox bEmail;
        private Utilidades.textbox bNombre;
        private Utilidades.label label4;
        private Utilidades.label label2;
        private Utilidades.label label1;
    }
}