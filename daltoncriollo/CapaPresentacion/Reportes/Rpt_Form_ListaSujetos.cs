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
    public partial class Rpt_Form_ListaSujetos : Form
    {
        public Rpt_Form_ListaSujetos()
        {
            InitializeComponent();
        }

        private void Rpt_Form_ListaSujetos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.spLisSujetos' Puede moverla o quitarla según sea necesario.
            this.spLisSujetosTableAdapter.Fill(this.dsSistema.spLisSujetos);

            this.reportViewer1.RefreshReport();
        }
    }
}
