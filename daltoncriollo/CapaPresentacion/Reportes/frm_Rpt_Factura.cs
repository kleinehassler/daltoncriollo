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
    public partial class frm_Rpt_Factura : Form
    {
        public frm_Rpt_Factura()
        {
            InitializeComponent();
        }

        private void frm_Rpt_Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.spDocumentos_Comprobante_Factura' Puede moverla o quitarla según sea necesario.
            this.spDocumentos_Comprobante_FacturaTableAdapter.Fill(this.dsSistema.spDocumentos_Comprobante_Factura, Variables.idDocumento);

            this.reportViewer1.RefreshReport();
        }
    }
}
