namespace CapaPresentacion
{
    partial class frmSistema
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDBodegas1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDArticulos1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSujetos1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDProduccion1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMIngresos1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMEgresos1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMFacturacion1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMProduccion1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuResumenes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRIngresos1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuREgresos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRKardex1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRProduccion1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUUsuarios1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUCClave = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.stbInferior = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatos,
            this.mnuMovimientos,
            this.mnuResumenes,
            this.mnuUsuarios,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuDatos
            // 
            this.mnuDatos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDBodegas1,
            this.mnuDArticulos1,
            this.mnuDSujetos1,
            this.mnuDProduccion1});
            this.mnuDatos.Name = "mnuDatos";
            this.mnuDatos.Size = new System.Drawing.Size(49, 20);
            this.mnuDatos.Text = "&Datos";
            // 
            // mnuDBodegas1
            // 
            this.mnuDBodegas1.Name = "mnuDBodegas1";
            this.mnuDBodegas1.Size = new System.Drawing.Size(135, 22);
            this.mnuDBodegas1.Text = "&Bodegas";
            this.mnuDBodegas1.Click += new System.EventHandler(this.bodegasToolStripMenuItem_Click);
            // 
            // mnuDArticulos1
            // 
            this.mnuDArticulos1.Name = "mnuDArticulos1";
            this.mnuDArticulos1.Size = new System.Drawing.Size(135, 22);
            this.mnuDArticulos1.Text = "&Articulos";
            this.mnuDArticulos1.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // mnuDSujetos1
            // 
            this.mnuDSujetos1.Name = "mnuDSujetos1";
            this.mnuDSujetos1.Size = new System.Drawing.Size(135, 22);
            this.mnuDSujetos1.Text = "S&ujetos";
            this.mnuDSujetos1.Click += new System.EventHandler(this.sujetosToolStripMenuItem_Click);
            // 
            // mnuDProduccion1
            // 
            this.mnuDProduccion1.Name = "mnuDProduccion1";
            this.mnuDProduccion1.Size = new System.Drawing.Size(135, 22);
            this.mnuDProduccion1.Text = "&Produccion";
            this.mnuDProduccion1.Click += new System.EventHandler(this.produccionToolStripMenuItem_Click);
            // 
            // mnuMovimientos
            // 
            this.mnuMovimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMIngresos1,
            this.mnuMEgresos1,
            this.mnuMFacturacion1,
            this.mnuMProduccion1});
            this.mnuMovimientos.Name = "mnuMovimientos";
            this.mnuMovimientos.Size = new System.Drawing.Size(89, 20);
            this.mnuMovimientos.Text = "&Movimientos";
            // 
            // mnuMIngresos1
            // 
            this.mnuMIngresos1.Name = "mnuMIngresos1";
            this.mnuMIngresos1.Size = new System.Drawing.Size(136, 22);
            this.mnuMIngresos1.Text = "&Ingresos";
            this.mnuMIngresos1.Click += new System.EventHandler(this.mnuMIngresos1_Click);
            // 
            // mnuMEgresos1
            // 
            this.mnuMEgresos1.Name = "mnuMEgresos1";
            this.mnuMEgresos1.Size = new System.Drawing.Size(136, 22);
            this.mnuMEgresos1.Text = "&Egresos";
            this.mnuMEgresos1.Click += new System.EventHandler(this.mnuMEgresos1_Click);
            // 
            // mnuMFacturacion1
            // 
            this.mnuMFacturacion1.Name = "mnuMFacturacion1";
            this.mnuMFacturacion1.Size = new System.Drawing.Size(136, 22);
            this.mnuMFacturacion1.Text = "&Facturacion";
            this.mnuMFacturacion1.Click += new System.EventHandler(this.mnuMFacturacion1_Click);
            // 
            // mnuMProduccion1
            // 
            this.mnuMProduccion1.Name = "mnuMProduccion1";
            this.mnuMProduccion1.Size = new System.Drawing.Size(136, 22);
            this.mnuMProduccion1.Text = "&Produccion";
            // 
            // mnuResumenes
            // 
            this.mnuResumenes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRIngresos1,
            this.mnuREgresos,
            this.mnuRKardex1,
            this.mnuRProduccion1});
            this.mnuResumenes.Name = "mnuResumenes";
            this.mnuResumenes.Size = new System.Drawing.Size(79, 20);
            this.mnuResumenes.Text = "&Resumenes";
            // 
            // mnuRIngresos1
            // 
            this.mnuRIngresos1.Name = "mnuRIngresos1";
            this.mnuRIngresos1.Size = new System.Drawing.Size(152, 22);
            this.mnuRIngresos1.Text = "I&ngresos";
            this.mnuRIngresos1.Click += new System.EventHandler(this.mnuRIngresos1_Click);
            // 
            // mnuREgresos
            // 
            this.mnuREgresos.Name = "mnuREgresos";
            this.mnuREgresos.Size = new System.Drawing.Size(152, 22);
            this.mnuREgresos.Text = "E&gresos";
            this.mnuREgresos.Click += new System.EventHandler(this.mnuREgresos_Click);
            // 
            // mnuRKardex1
            // 
            this.mnuRKardex1.Name = "mnuRKardex1";
            this.mnuRKardex1.Size = new System.Drawing.Size(152, 22);
            this.mnuRKardex1.Text = "&Kardex";
            this.mnuRKardex1.Click += new System.EventHandler(this.mnuRKardex1_Click);
            // 
            // mnuRProduccion1
            // 
            this.mnuRProduccion1.Name = "mnuRProduccion1";
            this.mnuRProduccion1.Size = new System.Drawing.Size(152, 22);
            this.mnuRProduccion1.Text = "Facturacion";
            this.mnuRProduccion1.Click += new System.EventHandler(this.produccionToolStripMenuItem2_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUUsuarios1,
            this.mnuUCClave});
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(64, 20);
            this.mnuUsuarios.Text = "&Usuarios";
            // 
            // mnuUUsuarios1
            // 
            this.mnuUUsuarios1.Name = "mnuUUsuarios1";
            this.mnuUUsuarios1.Size = new System.Drawing.Size(164, 22);
            this.mnuUUsuarios1.Text = "U&suarios";
            this.mnuUUsuarios1.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // mnuUCClave
            // 
            this.mnuUCClave.Name = "mnuUCClave";
            this.mnuUCClave.Size = new System.Drawing.Size(164, 22);
            this.mnuUCClave.Text = "Cam&bio de Clave";
            this.mnuUCClave.Click += new System.EventHandler(this.mnuUCClave_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbInferior});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // stbInferior
            // 
            this.stbInferior.Name = "stbInferior";
            this.stbInferior.Size = new System.Drawing.Size(235, 17);
            this.stbInferior.Text = "Dalton Criollo :: Inst. Bolivar Madero Vargas";
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmSistema";
            this.Text = "Sistema de Control de de Bodegas, Produccion y Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSistema_FormClosing);
            this.Load += new System.EventHandler(this.frmSistema_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel stbInferior;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuDatos;
        private System.Windows.Forms.ToolStripMenuItem mnuDBodegas1;
        private System.Windows.Forms.ToolStripMenuItem mnuDArticulos1;
        private System.Windows.Forms.ToolStripMenuItem mnuDSujetos1;
        private System.Windows.Forms.ToolStripMenuItem mnuDProduccion1;
        private System.Windows.Forms.ToolStripMenuItem mnuMovimientos;
        private System.Windows.Forms.ToolStripMenuItem mnuMIngresos1;
        private System.Windows.Forms.ToolStripMenuItem mnuMEgresos1;
        private System.Windows.Forms.ToolStripMenuItem mnuMFacturacion1;
        private System.Windows.Forms.ToolStripMenuItem mnuMProduccion1;
        private System.Windows.Forms.ToolStripMenuItem mnuResumenes;
        private System.Windows.Forms.ToolStripMenuItem mnuRIngresos1;
        private System.Windows.Forms.ToolStripMenuItem mnuREgresos;
        private System.Windows.Forms.ToolStripMenuItem mnuRKardex1;
        private System.Windows.Forms.ToolStripMenuItem mnuRProduccion1;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuUUsuarios1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuUCClave;
    }
}



