namespace Inventario
{
    partial class mUnidades
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
            this.bDescripcion = new Utilidades.textbox(this.components);
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
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(657, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckEstado);
            this.panel2.Controls.Add(this.bDescripcion);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bCodigo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Size = new System.Drawing.Size(657, 434);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.bCodigo, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.bDescripcion, 0);
            this.panel2.Controls.SetChildIndex(this.ckEstado, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo:";
            // 
            // bCodigo
            // 
            this.bCodigo.BackColor = System.Drawing.Color.DarkRed;
            this.bCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCodigo.ForeColor = System.Drawing.Color.White;
            this.bCodigo.Location = new System.Drawing.Point(122, 82);
            this.bCodigo.Name = "bCodigo";
            this.bCodigo.Size = new System.Drawing.Size(100, 25);
            this.bCodigo.TabIndex = 0;
            this.bCodigo.Validar = true;
            this.bCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.bCodigo_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descripcion:";
            // 
            // bDescripcion
            // 
            this.bDescripcion.BackColor = System.Drawing.Color.DarkRed;
            this.bDescripcion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDescripcion.ForeColor = System.Drawing.Color.White;
            this.bDescripcion.Location = new System.Drawing.Point(153, 146);
            this.bDescripcion.Name = "bDescripcion";
            this.bDescripcion.Size = new System.Drawing.Size(195, 25);
            this.bDescripcion.TabIndex = 1;
            this.bDescripcion.Validar = true;
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckEstado.Location = new System.Drawing.Point(58, 213);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(73, 24);
            this.ckEstado.TabIndex = 2;
            this.ckEstado.Text = "Estado";
            this.ckEstado.UseVisualStyleBackColor = true;
            // 
            // mUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 434);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "mUnidades";
            this.Text = "Registro Unidades";
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
        private Utilidades.textbox bDescripcion;
        private Utilidades.label label1;
        private System.Windows.Forms.CheckBox ckEstado;
    }
}