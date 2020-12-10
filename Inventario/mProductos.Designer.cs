namespace Inventario
{
    partial class mProductos
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
            this.bNombre = new Utilidades.textbox(this.components);
            this.label2 = new Utilidades.label(this.components);
            this.bPreventa = new Utilidades.textbox(this.components);
            this.bPrecompra = new Utilidades.textbox(this.components);
            this.label4 = new Utilidades.label(this.components);
            this.label5 = new Utilidades.label(this.components);
            this.bExistencia = new Utilidades.textbox(this.components);
            this.label6 = new Utilidades.label(this.components);
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.bPunreo = new Utilidades.textbox(this.components);
            this.label7 = new Utilidades.label(this.components);
            this.bCodDep = new Utilidades.textbox(this.components);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.bCodDep);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.bPunreo);
            this.panel2.Controls.Add(this.ckEstado);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bExistencia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.bPrecompra);
            this.panel2.Controls.Add(this.bPreventa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.bNombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bCodigo);
            this.panel2.Controls.Add(this.label3);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 76);
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
            this.bCodigo.Location = new System.Drawing.Point(118, 76);
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
            this.label1.Location = new System.Drawing.Point(50, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // bNombre
            // 
            this.bNombre.BackColor = System.Drawing.Color.DarkRed;
            this.bNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNombre.ForeColor = System.Drawing.Color.White;
            this.bNombre.Location = new System.Drawing.Point(126, 143);
            this.bNombre.Name = "bNombre";
            this.bNombre.Size = new System.Drawing.Size(154, 25);
            this.bNombre.TabIndex = 1;
            this.bNombre.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pre-Venta:";
            // 
            // bPreventa
            // 
            this.bPreventa.BackColor = System.Drawing.Color.DarkRed;
            this.bPreventa.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPreventa.ForeColor = System.Drawing.Color.White;
            this.bPreventa.Location = new System.Drawing.Point(137, 207);
            this.bPreventa.Name = "bPreventa";
            this.bPreventa.Size = new System.Drawing.Size(143, 25);
            this.bPreventa.TabIndex = 2;
            this.bPreventa.Validar = true;
            // 
            // bPrecompra
            // 
            this.bPrecompra.BackColor = System.Drawing.Color.DarkRed;
            this.bPrecompra.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrecompra.ForeColor = System.Drawing.Color.White;
            this.bPrecompra.Location = new System.Drawing.Point(152, 268);
            this.bPrecompra.Name = "bPrecompra";
            this.bPrecompra.Size = new System.Drawing.Size(128, 25);
            this.bPrecompra.TabIndex = 3;
            this.bPrecompra.Validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Pre-Compra:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Existencia:";
            // 
            // bExistencia
            // 
            this.bExistencia.BackColor = System.Drawing.Color.DarkRed;
            this.bExistencia.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bExistencia.ForeColor = System.Drawing.Color.White;
            this.bExistencia.Location = new System.Drawing.Point(136, 334);
            this.bExistencia.Name = "bExistencia";
            this.bExistencia.Size = new System.Drawing.Size(144, 25);
            this.bExistencia.TabIndex = 5;
            this.bExistencia.Validar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Punreo:";
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckEstado.Location = new System.Drawing.Point(368, 147);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(73, 24);
            this.ckEstado.TabIndex = 7;
            this.ckEstado.Text = "Estado";
            this.ckEstado.UseVisualStyleBackColor = true;
            // 
            // bPunreo
            // 
            this.bPunreo.BackColor = System.Drawing.Color.DarkRed;
            this.bPunreo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPunreo.ForeColor = System.Drawing.Color.White;
            this.bPunreo.Location = new System.Drawing.Point(432, 76);
            this.bPunreo.Name = "bPunreo";
            this.bPunreo.Size = new System.Drawing.Size(154, 25);
            this.bPunreo.TabIndex = 6;
            this.bPunreo.Validar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(364, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "C. Dep.:";
            // 
            // bCodDep
            // 
            this.bCodDep.BackColor = System.Drawing.Color.DarkRed;
            this.bCodDep.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCodDep.ForeColor = System.Drawing.Color.White;
            this.bCodDep.Location = new System.Drawing.Point(432, 207);
            this.bCodDep.Name = "bCodDep";
            this.bCodDep.Size = new System.Drawing.Size(63, 25);
            this.bCodDep.TabIndex = 8;
            this.bCodDep.Validar = true;
            // 
            // mProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 434);
            this.Name = "mProductos";
            this.Text = "Registro Productos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Utilidades.label label3;
        private Utilidades.textbox bCodDep;
        private Utilidades.label label7;
        private Utilidades.textbox bPunreo;
        private System.Windows.Forms.CheckBox ckEstado;
        private Utilidades.label label6;
        private Utilidades.textbox bExistencia;
        private Utilidades.label label5;
        private Utilidades.label label4;
        private Utilidades.textbox bPrecompra;
        private Utilidades.textbox bPreventa;
        private Utilidades.label label2;
        private Utilidades.textbox bNombre;
        private Utilidades.label label1;
        private Utilidades.textbox bCodigo;
    }
}