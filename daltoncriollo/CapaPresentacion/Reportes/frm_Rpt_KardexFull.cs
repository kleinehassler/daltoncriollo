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
    public partial class frm_Rpt_KardexFull : Form
    {
        public frm_Rpt_KardexFull()
        {
            InitializeComponent();
        }

        private void frm_Rpt_KardexFull_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.spKardex' Puede moverla o quitarla según sea necesario.
            this.spKardexTableAdapter.Fill(this.dsSistema.spKardex, Variables.idArtKardex);

            this.reportViewer1.RefreshReport();
        }
    }
}
