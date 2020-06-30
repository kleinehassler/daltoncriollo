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
    public partial class frm_rptListaBodega : Form
    {
        public frm_rptListaBodega()
        {
            InitializeComponent();
        }

        private void frm_rptListaBodega_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.spLisBodegas' Puede moverla o quitarla según sea necesario.
            this.spLisBodegasTableAdapter.Fill(this.dsSistema.spLisBodegas);

            this.reportViewer1.RefreshReport();
        }
    }
}
