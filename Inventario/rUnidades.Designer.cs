namespace Inventario
{
    partial class rUnidades
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
            this.UnidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InventarioDataSet = new Inventario.InventarioDataSet();
            this.unidadesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UnidadesTableAdapter = new Inventario.InventarioDataSetTableAdapters.UnidadesTableAdapter();
            this.suplidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UnidadesBindingSource
            // 
            this.UnidadesBindingSource.DataMember = "Unidades";
            this.UnidadesBindingSource.DataSource = this.InventarioDataSet;
            // 
            // InventarioDataSet
            // 
            this.InventarioDataSet.DataSetName = "InventarioDataSet";
            this.InventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unidadesBindingSource1
            // 
            this.unidadesBindingSource1.DataSource = typeof(Inventario.Unidades);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosUnidades";
            reportDataSource1.Value = this.UnidadesBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.unidadesBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventario.rUnidades.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(732, 632);
            this.reportViewer1.TabIndex = 3;
            // 
            // UnidadesTableAdapter
            // 
            this.UnidadesTableAdapter.ClearBeforeFill = true;
            // 
            // suplidoresBindingSource
            // 
            this.suplidoresBindingSource.DataSource = typeof(Inventario.Suplidores);
            // 
            // rUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 632);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "rUnidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Unidades";
            this.Load += new System.EventHandler(this.rUnidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource UnidadesBindingSource;
        private InventarioDataSet InventarioDataSet;
        private InventarioDataSetTableAdapters.UnidadesTableAdapter UnidadesTableAdapter;
        private System.Windows.Forms.BindingSource unidadesBindingSource1;
        private System.Windows.Forms.BindingSource suplidoresBindingSource;
    }
}