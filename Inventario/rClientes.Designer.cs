namespace Inventario
{
    partial class rClientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioDataSet = new Inventario.InventarioDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientesTableAdapter = new Inventario.InventarioDataSetTableAdapters.ClientesTableAdapter();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            this.ClientesBindingSource.DataSource = this.InventarioDataSet;
            // 
            // InventarioDataSet
            // 
            this.InventarioDataSet.DataSetName = "InventarioDataSet";
            this.InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosClientes";
            reportDataSource1.Value = this.ClientesBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.clientesBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.rClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(960, 689);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClientesTableAdapter
            // 
            this.ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataSource = typeof(Inventario.Clientes);
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataSource = typeof(Inventario.Clientes);
            // 
            // rClientes
            // 
            this.ClientSize = new System.Drawing.Size(960, 689);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "rClientes";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private InventarioDataSet InventarioDataSet;
        private InventarioDataSetTableAdapters.ClientesTableAdapter ClientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
    }
}