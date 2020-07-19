namespace CapaPresentacion.Reportes
{
    partial class frm_rpt_ListaUsuarios
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
            this.spLisUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSistema = new CapaPresentacion.Reportes.dsSistema();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spLisUsuariosTableAdapter = new CapaPresentacion.Reportes.dsSistemaTableAdapters.spLisUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spLisUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // spLisUsuariosBindingSource
            // 
            this.spLisUsuariosBindingSource.DataMember = "spLisUsuarios";
            this.spLisUsuariosBindingSource.DataSource = this.dsSistema;
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
            reportDataSource1.Value = this.spLisUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.rptListaUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(604, 451);
            this.reportViewer1.TabIndex = 0;
            // 
            // spLisUsuariosTableAdapter
            // 
            this.spLisUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // frm_rpt_ListaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 451);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_rpt_ListaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Usuarios";
            this.Load += new System.EventHandler(this.frm_rpt_ListaUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spLisUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spLisUsuariosBindingSource;
        private dsSistema dsSistema;
        private dsSistemaTableAdapters.spLisUsuariosTableAdapter spLisUsuariosTableAdapter;
    }
}