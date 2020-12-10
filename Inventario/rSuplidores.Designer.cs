namespace Inventario
{
    partial class rSuplidores
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
            this.SuplidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioDataSet = new Inventario.InventarioDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuplidorTableAdapter = new Inventario.InventarioDataSetTableAdapters.SuplidorTableAdapter();
            this.suplidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suplidoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.suplidoresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SuplidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // SuplidorBindingSource
            // 
            this.SuplidorBindingSource.DataMember = "Suplidor";
            this.SuplidorBindingSource.DataSource = this.InventarioDataSet;
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
            reportDataSource1.Name = "DatosSuplidores";
            reportDataSource1.Value = this.SuplidorBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.suplidoresBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.rSuplidores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(871, 689);
            this.reportViewer1.TabIndex = 1;
            // 
            // SuplidorTableAdapter
            // 
            this.SuplidorTableAdapter.ClearBeforeFill = true;
            // 
            // suplidoresBindingSource
            // 
            this.suplidoresBindingSource.DataSource = typeof(Inventario.Suplidores);
            // 
            // suplidoresBindingSource1
            // 
            this.suplidoresBindingSource1.DataSource = typeof(Inventario.Suplidores);
            // 
            // suplidoresBindingSource2
            // 
            this.suplidoresBindingSource2.DataSource = typeof(Inventario.Suplidores);
            // 
            // rSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 689);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rSuplidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rSuplidores";
            this.Load += new System.EventHandler(this.rSuplidores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SuplidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SuplidorBindingSource;
        private InventarioDataSet InventarioDataSet;
        private InventarioDataSetTableAdapters.SuplidorTableAdapter SuplidorTableAdapter;
        private System.Windows.Forms.BindingSource suplidoresBindingSource;
        private System.Windows.Forms.BindingSource suplidoresBindingSource1;
        private System.Windows.Forms.BindingSource suplidoresBindingSource2;
    }
}