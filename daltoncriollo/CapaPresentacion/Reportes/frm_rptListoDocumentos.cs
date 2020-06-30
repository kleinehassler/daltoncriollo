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
    public partial class frm_rptListoDocumentos : Form
    {
        public frm_rptListoDocumentos()
        {
            InitializeComponent();
        }

        private void frm_rptListoDocumentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.spListDocuments' Puede moverla o quitarla según sea necesario.
            this.spListDocumentsTableAdapter.Fill(this.dsSistema.spListDocuments);

            this.reportViewer1.RefreshReport();
        }
    }
}
