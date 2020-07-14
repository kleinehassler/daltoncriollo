using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace CapaPresentacion
{
    public partial class frmSistema : Form
    {
        private int childFormNumber = 0;
        public int idUsuario;
        public int idRol;
        public string NombreUsr;
        public string LoginUsr;
        public string RolNombre;
        public bool EstadoUsr;

        public frmSistema()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Usuarios frm = new P_Usuarios();
            frm.Show();
        }

        private void sujetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Sujetos frm = new P_Sujetos();
            frm.MdiParent = this;
            frm.Show();

        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Articulo frm = new P_Articulo();
            frm.MdiParent = this;
            frm.Show();

        }

        private void produccionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          
        }

        private void bodegasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Bodega frm = new P_Bodega();
            frm.MdiParent = this;
            frm.Show();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            P_Produccion frm = new P_Produccion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void frmSistema_Load(object sender, EventArgs e)
        {
            stbInferior.Text = "Desarrollado por Dalton Criollo :: Inst. Bolivar Madero Vargas :: Usuario Actual --> " + this.NombreUsr;

            if (this.idRol.Equals(1))
            {
                mnuDatos.Enabled = true;
                mnuDArticulos1.Enabled = true;
                mnuDBodegas1.Enabled = true;
                mnuDProduccion1.Enabled = true;
                mnuDSujetos1.Enabled = true;

                mnuMovimientos.Enabled = true;
                mnuMIngresos1.Enabled = true;
                mnuMEgresos1.Enabled = true;
                mnuMFacturacion1.Enabled = true;
                mnuMProduccion1.Enabled = true;

                mnuResumenes.Enabled = true;
                mnuRIngresos1.Enabled = true;
                mnuREgresos.Enabled = true;
                mnuRProduccion1.Enabled = true;
                mnuRKardex1.Enabled = true;

                mnuUsuarios.Enabled = true;
                mnuUUsuarios1.Enabled = true;
                mnuUCClave.Enabled = true;

            }
            else if (this.idRol.Equals(2))
            {
                mnuDatos.Enabled = true;
                mnuDArticulos1.Enabled = true;
                mnuDBodegas1.Enabled = false;
                mnuDProduccion1.Enabled = true;
                mnuDSujetos1.Enabled = true;

                mnuMovimientos.Enabled = true;
                mnuMIngresos1.Enabled = true;
                mnuMEgresos1.Enabled = true;
                mnuMFacturacion1.Enabled = false;
                mnuMProduccion1.Enabled = true;

                mnuResumenes.Enabled = true;
                mnuRIngresos1.Enabled = true;
                mnuREgresos.Enabled = true;
                mnuRProduccion1.Enabled = true;
                mnuRKardex1.Enabled = true;

                mnuUsuarios.Enabled = true;
                mnuUUsuarios1.Enabled = false;
                mnuUCClave.Enabled = true;

            }
            else if (this.idRol.Equals(3))
            {
                mnuDatos.Enabled = true;
                mnuDArticulos1.Enabled = false;
                mnuDBodegas1.Enabled = false;
                mnuDProduccion1.Enabled = false;
                mnuDSujetos1.Enabled = true;

                mnuMovimientos.Enabled = true;
                mnuMIngresos1.Enabled = false;
                mnuMEgresos1.Enabled = false;
                mnuMFacturacion1.Enabled = true;
                mnuMProduccion1.Enabled = false;

                mnuResumenes.Enabled = false;
                mnuRIngresos1.Enabled = false;
                mnuREgresos.Enabled = false;
                mnuRProduccion1.Enabled = false;
                mnuRKardex1.Enabled = false;

                mnuUsuarios.Enabled = true;
                mnuUUsuarios1.Enabled = false;
                mnuUCClave.Enabled = true;

            }
            else
            {
                mnuDatos.Enabled = false;
                mnuDArticulos1.Enabled = false;
                mnuDBodegas1.Enabled = false;
                mnuDProduccion1.Enabled = false;
                mnuDSujetos1.Enabled = false;

                mnuMovimientos.Enabled = false;
                mnuMIngresos1.Enabled = false;
                mnuMEgresos1.Enabled = false;
                mnuMFacturacion1.Enabled = false;
                mnuMProduccion1.Enabled = false;

                mnuResumenes.Enabled = false;
                mnuRIngresos1.Enabled = false;
                mnuREgresos.Enabled = false;
                mnuRProduccion1.Enabled = false;
                mnuRKardex1.Enabled = false;

                mnuUsuarios.Enabled = false;
                mnuUUsuarios1.Enabled = false;
                mnuUCClave.Enabled = false;

            }


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("Desea Salir del Sistema", "Dalton Criollo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void frmSistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mnuMIngresos1_Click(object sender, EventArgs e)
        {
            frmIngreso frm = new frmIngreso();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuMEgresos1_Click(object sender, EventArgs e)
        {
            P_Egreso frm = new P_Egreso();
            frm.MdiParent = this;
            frm.Show();

        }

        private void mnuMFacturacion1_Click(object sender, EventArgs e)
        {
            P_Factura frm = new P_Factura();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}
