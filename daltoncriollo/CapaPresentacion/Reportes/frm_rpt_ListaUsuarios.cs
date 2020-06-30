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
    public partial class frm_rpt_ListaUsuarios : Form
    {
        public frm_rpt_ListaUsuarios()
        {
            InitializeComponent();
        }

        private void frm_rpt_ListaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistema.spLisUsuarios' Puede moverla o quitarla según sea necesario.
            this.spLisUsuariosTableAdapter.Fill(this.dsSistema.spLisUsuarios);

            this.reportViewer1.RefreshReport();
        }
    }
}
