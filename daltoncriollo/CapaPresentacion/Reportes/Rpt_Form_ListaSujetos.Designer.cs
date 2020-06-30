namespace CapaPresentacion.Reportes
{
    partial class Rpt_Form_ListaSujetos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsSistema = new CapaPresentacion.Reportes.dsSistema();
            this.spLisSujetosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spLisSujetosTableAdapter = new CapaPresentacion.Reportes.dsSistemaTableAdapters.spLisSujetosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLisSujetosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spLisSujetosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptListaSujeto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(945, 262);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "dsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spLisSujetosBindingSource
            // 
            this.spLisSujetosBindingSource.DataMember = "spLisSujetos";
            this.spLisSujetosBindingSource.DataSource = this.dsSistema;
            // 
            // spLisSujetosTableAdapter
            // 
            this.spLisSujetosTableAdapter.ClearBeforeFill = true;
            // 
            // Rpt_Form_ListaSujetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 262);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rpt_Form_ListaSujetos";
            this.Text = "Rpt_Form_ListaSujetos";
            this.Load += new System.EventHandler(this.Rpt_Form_ListaSujetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spLisSujetosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spLisSujetosBindingSource;
        private dsSistema dsSistema;
        private dsSistemaTableAdapters.spLisSujetosTableAdapter spLisSujetosTableAdapter;
    }
}