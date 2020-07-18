namespace CapaPresentacion.Reportes
{
    partial class frm_Rpt_Egresos
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
            this.spDocumentos_Comprobante_EgresoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistema = new CapaPresentacion.Reportes.dsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spDocumentos_Comprobante_EgresoTableAdapter = new CapaPresentacion.Reportes.dsSistemaTableAdapters.spDocumentos_Comprobante_EgresoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentos_Comprobante_EgresoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // spDocumentos_Comprobante_EgresoBindingSource
            // 
            this.spDocumentos_Comprobante_EgresoBindingSource.DataMember = "spDocumentos_Comprobante_Egreso";
            this.spDocumentos_Comprobante_EgresoBindingSource.DataSource = this.dsSistema;
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
            reportDataSource1.Value = this.spDocumentos_Comprobante_EgresoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptDocumentoEgreso.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(749, 444);
            this.reportViewer1.TabIndex = 0;
            // 
            // spDocumentos_Comprobante_EgresoTableAdapter
            // 
            this.spDocumentos_Comprobante_EgresoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Rpt_Egresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 444);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Rpt_Egresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobantes de Egresos";
            this.Load += new System.EventHandler(this.frm_Rpt_Egresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentos_Comprobante_EgresoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spDocumentos_Comprobante_EgresoBindingSource;
        private dsSistema dsSistema;
        private dsSistemaTableAdapters.spDocumentos_Comprobante_EgresoTableAdapter spDocumentos_Comprobante_EgresoTableAdapter;
    }
}