using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class frmConsulta_Factura : Form
    {
        public frmConsulta_Factura()
        {
            InitializeComponent();
        }


        private void Buscar()
        {
            try
            {
                dgvResumen.DataSource = N_Factura.ConsultarFechas(Convert.ToDateTime(ddesde.Value), Convert.ToDateTime(dhasta.Value));
                this.formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void formato()
        {
            dgvResumen.Columns[0].Visible = false;
            dgvResumen.Columns[1].Visible = false;
            dgvResumen.Columns[2].Width = 150;
            dgvResumen.Columns[3].Width = 150;
            dgvResumen.Columns[4].Visible = false;
            dgvResumen.Columns[5].Width = 100;
            dgvResumen.Columns[6].Width = 100;
            dgvResumen.Columns[7].Width = 100;
            dgvResumen.Columns[8].Visible = false;
            dgvResumen.Columns[9].Visible = false;
            dgvResumen.Columns[11].Width = 100;
            dgvResumen.Columns[11].Visible = false;
            dgvResumen.Columns[12].Visible = false;

        }

        private void Limpiar()
        {
         
            dgvResumen.Columns[0].Visible = false;
      

        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "D Criollo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "D Criollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
                
        private void dgvResumen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ddesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void cmdPrint_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void dhasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmConsulta_Factura_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Variables.idDocumento = Convert.ToInt32(dgvResumen.CurrentRow.Cells["ID"].Value);
                Reportes.frm_Rpt_Factura rpt = new Reportes.frm_Rpt_Factura();
                rpt.ShowDialog();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
    }
}
