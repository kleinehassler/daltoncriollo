namespace CapaPresentacion.Reportes
{
    partial class frm_Rpt_Factura
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
            this.spDocumentos_Comprobante_FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistema = new CapaPresentacion.Reportes.dsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spDocumentos_Comprobante_FacturaTableAdapter = new CapaPresentacion.Reportes.dsSistemaTableAdapters.spDocumentos_Comprobante_FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentos_Comprobante_FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // spDocumentos_Comprobante_FacturaBindingSource
            // 
            this.spDocumentos_Comprobante_FacturaBindingSource.DataMember = "spDocumentos_Comprobante_Factura";
            this.spDocumentos_Comprobante_FacturaBindingSource.DataSource = this.dsSistema;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "dsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spDocumentos_Comprobante_FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptDocumentoFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(744, 455);
            this.reportViewer1.TabIndex = 0;
            // 
            // spDocumentos_Comprobante_FacturaTableAdapter
            // 
            this.spDocumentos_Comprobante_FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Rpt_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 455);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Rpt_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.frm_Rpt_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentos_Comprobante_FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spDocumentos_Comprobante_FacturaBindingSource;
        private dsSistema dsSistema;
        private dsSistemaTableAdapters.spDocumentos_Comprobante_FacturaTableAdapter spDocumentos_Comprobante_FacturaTableAdapter;
    }
}