namespace CapaPresentacion.Reportes
{
    partial class frmReporte_ListaArticulo
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
            this.spLisArtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistema = new CapaPresentacion.Reportes.dsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spLisArtTableAdapter = new CapaPresentacion.Reportes.dsSistemaTableAdapters.spLisArtTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spLisArtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // spLisArtBindingSource
            // 
            this.spLisArtBindingSource.DataMember = "spLisArt";
            this.spLisArtBindingSource.DataSource = this.dsSistema;
            // 
            // dsSistema
            // 
            this.dsSistema.DataSetName = "dsSistema";
            this.dsSistema.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dtsArticulos";
            reportDataSource1.Value = this.spLisArtBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptListaArticulos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(782, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // spLisArtTableAdapter
            // 
            this.spLisArtTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporte_ListaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 504);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporte_ListaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Articulos";
            this.Load += new System.EventHandler(this.frmReporte_ListaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spLisArtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spLisArtBindingSource;
        private dsSistema dsSistema;
        private dsSistemaTableAdapters.spLisArtTableAdapter spLisArtTableAdapter;
    }
}