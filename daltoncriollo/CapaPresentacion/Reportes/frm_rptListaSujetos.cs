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
    public partial class frm_rptListaSujetos : Form
    {
        public frm_rptListaSujetos()
        {
            InitializeComponent();
        }

        private void frm_rptListaSujetos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.spLisSujetos' Puede moverla o quitarla según sea necesario.
            this.spLisSujetosTableAdapter.Fill(this.dsSistema.spLisSujetos);

            this.reportViewer1.RefreshReport();
        }
    }
}
