namespace CapaPresentacion.Reportes
{
    partial class frm_Rpt_Ingresos
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
            this.spDocumentos_Comprobante_IngresoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistema = new CapaPresentacion.Reportes.dsSistema();
            this.spDocumentos_Comprobante_IngresoTableAdapter = new CapaPresentacion.Reportes.dsSistemaTableAdapters.spDocumentos_Comprobante_IngresoTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentos_Comprobante_IngresoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // spDocumentos_Comprobante_IngresoBindingSource
            // 
            this.spDocumentos_Comprobante_IngresoBindingSource.DataMember = "spDocumentos_Comprobante_Ingreso";
            this.spDocumentos_Comprobante_IngresoBindingSource.DataSource = this.dsSistema;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "dsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spDocumentos_Comprobante_IngresoTableAdapter
            // 
            this.spDocumentos_Comprobante_IngresoTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.spDocumentos_Comprobante_IngresoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptDocumentoIngresos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(756, 476);
            this.reportViewer1.TabIndex = 0;
            // 
            // frm_Rpt_Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 476);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Rpt_Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documento Ingreso";
            this.Load += new System.EventHandler(this.frm_Rpt_Ingresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spDocumentos_Comprobante_IngresoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsSistema dsSistema;
        private System.Windows.Forms.BindingSource spDocumentos_Comprobante_IngresoBindingSource;
        private dsSistemaTableAdapters.spDocumentos_Comprobante_IngresoTableAdapter spDocumentos_Comprobante_IngresoTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}