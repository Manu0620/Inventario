namespace Inventario
{
    partial class mFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mFactura));
            this.dataDetalle = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new Utilidades.label(this.components);
            this.label3 = new Utilidades.label(this.components);
            this.label4 = new Utilidades.label(this.components);
            this.bFecha = new Utilidades.maskedTexbox(this.components);
            this.bNumero = new Utilidades.textbox(this.components);
            this.bCodcli = new Utilidades.textbox(this.components);
            this.label5 = new Utilidades.label(this.components);
            this.label6 = new Utilidades.label(this.components);
            this.label7 = new Utilidades.label(this.components);
            this.label8 = new Utilidades.label(this.components);
            this.label9 = new Utilidades.label(this.components);
            this.bNumerodetalle = new Utilidades.textbox(this.components);
            this.codProducto = new Utilidades.textbox(this.components);
            this.bCantidad = new Utilidades.textbox(this.components);
            this.bPrecio = new Utilidades.textbox(this.components);
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.label2 = new Utilidades.label(this.components);
            this.label10 = new Utilidades.label(this.components);
            this.bEmail = new Utilidades.textbox(this.components);
            this.bnCliente = new Utilidades.textbox(this.components);
            this.bAñadir = new Utilidades.boton(this.components);
            this.label11 = new Utilidades.label(this.components);
            this.Total = new Utilidades.label(this.components);
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.bModificar = new Utilidades.boton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bConsultar
            // 
            this.bConsultar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.bConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.bConsultar.Location = new System.Drawing.Point(0, 331);
            this.bConsultar.Text = "Productos";
            // 
            // reporte
            // 
            this.reporte.ServerReport.BearerToken = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Location = new System.Drawing.Point(832, 0);
            this.panel1.Size = new System.Drawing.Size(144, 535);
            this.panel1.Controls.SetChildIndex(this.bConsultar, 0);
            this.panel1.Controls.SetChildIndex(this.Cerrar, 0);
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.bModificar);
            this.panel2.Controls.Add(this.Total);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.bAñadir);
            this.panel2.Controls.Add(this.bnCliente);
            this.panel2.Controls.Add(this.bEmail);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ckEstado);
            this.panel2.Controls.Add(this.bPrecio);
            this.panel2.Controls.Add(this.bCantidad);
            this.panel2.Controls.Add(this.codProducto);
            this.panel2.Controls.Add(this.bNumerodetalle);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bCodcli);
            this.panel2.Controls.Add(this.bNumero);
            this.panel2.Controls.Add(this.bFecha);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataDetalle);
            this.panel2.Size = new System.Drawing.Size(832, 535);
            this.panel2.Controls.SetChildIndex(this.dataDetalle, 0);
            this.panel2.Controls.SetChildIndex(this.label1, 0);
            this.panel2.Controls.SetChildIndex(this.label3, 0);
            this.panel2.Controls.SetChildIndex(this.label4, 0);
            this.panel2.Controls.SetChildIndex(this.bFecha, 0);
            this.panel2.Controls.SetChildIndex(this.bNumero, 0);
            this.panel2.Controls.SetChildIndex(this.bCodcli, 0);
            this.panel2.Controls.SetChildIndex(this.label5, 0);
            this.panel2.Controls.SetChildIndex(this.label6, 0);
            this.panel2.Controls.SetChildIndex(this.label7, 0);
            this.panel2.Controls.SetChildIndex(this.label8, 0);
            this.panel2.Controls.SetChildIndex(this.label9, 0);
            this.panel2.Controls.SetChildIndex(this.bNumerodetalle, 0);
            this.panel2.Controls.SetChildIndex(this.codProducto, 0);
            this.panel2.Controls.SetChildIndex(this.bCantidad, 0);
            this.panel2.Controls.SetChildIndex(this.bPrecio, 0);
            this.panel2.Controls.SetChildIndex(this.ckEstado, 0);
            this.panel2.Controls.SetChildIndex(this.label2, 0);
            this.panel2.Controls.SetChildIndex(this.label10, 0);
            this.panel2.Controls.SetChildIndex(this.bEmail, 0);
            this.panel2.Controls.SetChildIndex(this.bnCliente, 0);
            this.panel2.Controls.SetChildIndex(this.bAñadir, 0);
            this.panel2.Controls.SetChildIndex(this.label11, 0);
            this.panel2.Controls.SetChildIndex(this.Total, 0);
            this.panel2.Controls.SetChildIndex(this.bModificar, 0);
            // 
            // dataDetalle
            // 
            this.dataDetalle.AllowUserToAddRows = false;
            this.dataDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataDetalle.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDetalle.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataDetalle.EnableHeadersVisualStyles = false;
            this.dataDetalle.GridColor = System.Drawing.Color.Lavender;
            this.dataDetalle.Location = new System.Drawing.Point(24, 156);
            this.dataDetalle.Name = "dataDetalle";
            this.dataDetalle.ReadOnly = true;
            this.dataDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dataDetalle.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataDetalle.Size = new System.Drawing.Size(472, 297);
            this.dataDetalle.TabIndex = 5;
            this.dataDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDetalle_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.DataPropertyName = "codpro";
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 89;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "Nombre";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 83;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column2.DataPropertyName = "canven";
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 87;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column3.DataPropertyName = "preven";
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "preven";
            this.Column4.HeaderText = "Importe";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(451, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cod. Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numero:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bFecha
            // 
            this.bFecha.BackColor = System.Drawing.Color.DarkRed;
            this.bFecha.BeepOnError = true;
            this.bFecha.Culture = new System.Globalization.CultureInfo("en-US");
            this.bFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFecha.ForeColor = System.Drawing.Color.White;
            this.bFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bFecha.Location = new System.Drawing.Point(301, 36);
            this.bFecha.Mask = "00/00/0000 90:00:00";
            this.bFecha.Name = "bFecha";
            this.bFecha.Size = new System.Drawing.Size(122, 25);
            this.bFecha.TabIndex = 11;
            this.bFecha.Validar = true;
            this.bFecha.ValidatingType = typeof(System.DateTime);
            // 
            // bNumero
            // 
            this.bNumero.BackColor = System.Drawing.Color.DarkRed;
            this.bNumero.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumero.ForeColor = System.Drawing.Color.White;
            this.bNumero.Location = new System.Drawing.Point(116, 38);
            this.bNumero.Name = "bNumero";
            this.bNumero.ReadOnly = true;
            this.bNumero.Size = new System.Drawing.Size(100, 25);
            this.bNumero.TabIndex = 10;
            this.bNumero.Validar = true;
            this.bNumero.Validating += new System.ComponentModel.CancelEventHandler(this.bNumero_Validating);
            // 
            // bCodcli
            // 
            this.bCodcli.BackColor = System.Drawing.Color.DarkRed;
            this.bCodcli.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCodcli.ForeColor = System.Drawing.Color.White;
            this.bCodcli.Location = new System.Drawing.Point(552, 36);
            this.bCodcli.Name = "bCodcli";
            this.bCodcli.Size = new System.Drawing.Size(100, 25);
            this.bCodcli.TabIndex = 0;
            this.bCodcli.Validar = true;
            this.bCodcli.Validating += new System.ComponentModel.CancelEventHandler(this.bCodcli_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(532, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Cantidad:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(532, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Numero:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(526, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "C-Producto:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(640, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 37);
            this.label9.TabIndex = 18;
            this.label9.Text = "Detalle";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bNumerodetalle
            // 
            this.bNumerodetalle.BackColor = System.Drawing.Color.DarkRed;
            this.bNumerodetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNumerodetalle.ForeColor = System.Drawing.Color.White;
            this.bNumerodetalle.Location = new System.Drawing.Point(604, 155);
            this.bNumerodetalle.Name = "bNumerodetalle";
            this.bNumerodetalle.ReadOnly = true;
            this.bNumerodetalle.Size = new System.Drawing.Size(71, 25);
            this.bNumerodetalle.TabIndex = 13;
            this.bNumerodetalle.Validar = false;
            // 
            // codProducto
            // 
            this.codProducto.BackColor = System.Drawing.Color.DarkRed;
            this.codProducto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codProducto.ForeColor = System.Drawing.Color.White;
            this.codProducto.Location = new System.Drawing.Point(623, 216);
            this.codProducto.Name = "codProducto";
            this.codProducto.Size = new System.Drawing.Size(174, 25);
            this.codProducto.TabIndex = 1;
            this.codProducto.Validar = false;
            this.codProducto.Validating += new System.ComponentModel.CancelEventHandler(this.codProducto_Validating);
            // 
            // bCantidad
            // 
            this.bCantidad.BackColor = System.Drawing.Color.DarkRed;
            this.bCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCantidad.ForeColor = System.Drawing.Color.White;
            this.bCantidad.Location = new System.Drawing.Point(612, 285);
            this.bCantidad.Name = "bCantidad";
            this.bCantidad.Size = new System.Drawing.Size(185, 25);
            this.bCantidad.TabIndex = 2;
            this.bCantidad.Validar = false;
            // 
            // bPrecio
            // 
            this.bPrecio.BackColor = System.Drawing.Color.DarkRed;
            this.bPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrecio.ForeColor = System.Drawing.Color.White;
            this.bPrecio.Location = new System.Drawing.Point(601, 350);
            this.bPrecio.Name = "bPrecio";
            this.bPrecio.ReadOnly = true;
            this.bPrecio.Size = new System.Drawing.Size(196, 25);
            this.bPrecio.TabIndex = 3;
            this.bPrecio.Validar = false;
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.Checked = true;
            this.ckEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckEstado.Enabled = false;
            this.ckEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ckEstado.Location = new System.Drawing.Point(690, 37);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(73, 24);
            this.ckEstado.TabIndex = 12;
            this.ckEstado.Text = "Estado";
            this.ckEstado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cliente:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(277, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Email:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bEmail
            // 
            this.bEmail.BackColor = System.Drawing.Color.DarkRed;
            this.bEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEmail.ForeColor = System.Drawing.Color.White;
            this.bEmail.Location = new System.Drawing.Point(324, 102);
            this.bEmail.Name = "bEmail";
            this.bEmail.ReadOnly = true;
            this.bEmail.Size = new System.Drawing.Size(200, 25);
            this.bEmail.TabIndex = 28;
            this.bEmail.TabStop = false;
            this.bEmail.Validar = true;
            // 
            // bnCliente
            // 
            this.bnCliente.BackColor = System.Drawing.Color.DarkRed;
            this.bnCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCliente.ForeColor = System.Drawing.Color.White;
            this.bnCliente.Location = new System.Drawing.Point(97, 102);
            this.bnCliente.Name = "bnCliente";
            this.bnCliente.ReadOnly = true;
            this.bnCliente.Size = new System.Drawing.Size(148, 25);
            this.bnCliente.TabIndex = 29;
            this.bnCliente.TabStop = false;
            this.bnCliente.Validar = true;
            // 
            // bAñadir
            // 
            this.bAñadir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.bAñadir.FlatAppearance.BorderSize = 2;
            this.bAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.bAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAñadir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAñadir.ForeColor = System.Drawing.Color.White;
            this.bAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAñadir.Location = new System.Drawing.Point(532, 410);
            this.bAñadir.Name = "bAñadir";
            this.bAñadir.Size = new System.Drawing.Size(143, 43);
            this.bAñadir.TabIndex = 4;
            this.bAñadir.Text = "Añadir producto";
            this.bAñadir.UseVisualStyleBackColor = true;
            this.bAñadir.Click += new System.EventHandler(this.bAñadir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(343, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 37);
            this.label11.TabIndex = 33;
            this.label11.Text = "Total:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(434, 470);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(72, 37);
            this.Total.TabIndex = 34;
            this.Total.Text = "0.00";
            this.Total.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Cerrar
            // 
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.Location = new System.Drawing.Point(110, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(22, 23);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 12;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Enabled = false;
            this.bModificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.bModificar.FlatAppearance.BorderSize = 2;
            this.bModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.bModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.ForeColor = System.Drawing.Color.White;
            this.bModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bModificar.Location = new System.Drawing.Point(692, 410);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(105, 43);
            this.bModificar.TabIndex = 38;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // mFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 535);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mFactura";
            this.Text = "mFactura";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataDetalle;
        private Utilidades.label label4;
        private Utilidades.label label3;
        private Utilidades.label label1;
        private Utilidades.textbox bPrecio;
        private Utilidades.textbox bCantidad;
        private Utilidades.textbox codProducto;
        private Utilidades.textbox bNumerodetalle;
        private Utilidades.label label9;
        private Utilidades.label label8;
        private Utilidades.label label7;
        private Utilidades.label label6;
        private Utilidades.label label5;
        private Utilidades.textbox bCodcli;
        private Utilidades.textbox bNumero;
        private System.Windows.Forms.CheckBox ckEstado;
        private Utilidades.textbox bnCliente;
        private Utilidades.textbox bEmail;
        private Utilidades.label label10;
        private Utilidades.label label2;
        private Utilidades.boton bAñadir;
        public Utilidades.maskedTexbox bFecha;
        private Utilidades.label Total;
        private Utilidades.label label11;
        private System.Windows.Forms.PictureBox Cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Utilidades.boton bModificar;
    }
}