namespace Inventario
{
    partial class rDepartamentos
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
            this.DepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioDataSet = new Inventario.InventarioDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DepartamentosTableAdapter = new Inventario.InventarioDataSetTableAdapters.DepartamentosTableAdapter();
            this.departamentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DepartamentosBindingSource
            // 
            this.DepartamentosBindingSource.DataMember = "Departamentos";
            this.DepartamentosBindingSource.DataSource = this.InventarioDataSet;
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
            reportDataSource1.Name = "DatosDepartamentos";
            reportDataSource1.Value = this.DepartamentosBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.departamentosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.rDepartamentos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(732, 632);
            this.reportViewer1.TabIndex = 2;
            // 
            // DepartamentosTableAdapter
            // 
            this.DepartamentosTableAdapter.ClearBeforeFill = true;
            // 
            // departamentosBindingSource1
            // 
            this.departamentosBindingSource1.DataSource = typeof(Inventario.Departamentos);
            // 
            // rDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 632);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rDepartamentos";
            this.Load += new System.EventHandler(this.rDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DepartamentosBindingSource;
        private InventarioDataSet InventarioDataSet;
        private InventarioDataSetTableAdapters.DepartamentosTableAdapter DepartamentosTableAdapter;
        private System.Windows.Forms.BindingSource departamentosBindingSource1;
    }
}