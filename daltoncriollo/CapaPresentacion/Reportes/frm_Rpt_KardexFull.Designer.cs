namespace CapaPresentacion.Reportes
{
    partial class frm_Rpt_KardexFull
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
            this.spKardexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistema = new CapaPresentacion.Reportes.dsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spKardexTableAdapter = new CapaPresentacion.Reportes.dsSistemaTableAdapters.spKardexTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spKardexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // spKardexBindingSource
            // 
            this.spKardexBindingSource.DataMember = "spKardex";
            this.spKardexBindingSource.DataSource = this.dsSistema;
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
            reportDataSource1.Value = this.spKardexBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptKardexFull.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(909, 498);
            this.reportViewer1.TabIndex = 0;
            // 
            // spKardexTableAdapter
            // 
            this.spKardexTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Rpt_KardexFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 498);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Rpt_KardexFull";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kardex";
            this.Load += new System.EventHandler(this.frm_Rpt_KardexFull_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spKardexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spKardexBindingSource;
        private dsSistema dsSistema;
        private dsSistemaTableAdapters.spKardexTableAdapter spKardexTableAdapter;
    }
}