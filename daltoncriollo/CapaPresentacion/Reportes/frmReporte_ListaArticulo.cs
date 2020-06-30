using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class frmReporte_ListaArticulo : Form
    {
        public frmReporte_ListaArticulo()
        {
            InitializeComponent();
        }

        private void frmReporte_ListaArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.spLisArt' Puede moverla o quitarla según sea necesario.
            this.spLisArtTableAdapter.Fill(this.dsSistema.spLisArt);

            this.reportViewer1.RefreshReport();
        }
    }
}
