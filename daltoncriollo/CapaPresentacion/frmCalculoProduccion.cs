using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class frmCalculoProduccion : Form
    {
        public frmCalculoProduccion()
        {
            InitializeComponent();
        }
        

        private void Buscar()
        {
            try
            {
                dgvReceta.DataSource = N_Produccion.BuscarMP(Convert.ToInt32(cboPT.SelectedValue), Convert.ToDecimal(txtQTY.Text));
                this.formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void formato()
        {
            
            dgvReceta.Columns[0].Visible = false;
            dgvReceta.Columns[1].Visible = false;
            dgvReceta.Columns[2].Visible = false;
            dgvReceta.Columns[3].Visible = false;
            dgvReceta.Columns[4].Visible = false;
            dgvReceta.Columns[5].Width = 250;
            dgvReceta.Columns[5].HeaderText = "Nombre de Materia Prima";
            dgvReceta.Columns[6].Visible = false;
            dgvReceta.Columns[7].Width = 200;
            dgvReceta.Columns[5].HeaderText = "Unidad de Medida";
            dgvReceta.Columns[8].Visible = false;
            dgvReceta.Columns[9].Visible = false;
            dgvReceta.Columns[10].Width = 200;
            dgvReceta.Columns[10].HeaderText = "Requerimiento";

        }

        private void Limpiar()
        {
               
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "D Criollo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "D Criollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarPT()
        {
            try
            {
                cboPT.DataSource = N_Produccion.SeleccionarPT();
                cboPT.ValueMember = "idPT";
                cboPT.DisplayMember = "NombrePT";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCalculoProduccion_Load(object sender, EventArgs e)
        {
            this.CargarPT();

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }


    }
}
