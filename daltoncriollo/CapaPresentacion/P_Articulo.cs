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
    public partial class P_Articulo : Form
    {
        public P_Articulo()
        {
            InitializeComponent();
        }


        private void Listar()
        {
            try
            {
                dataGridView1.DataSource = N_Articulo.Listar();
                this.formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                dataGridView1.DataSource = N_Articulo.Buscar(txtBuscar.Text);
                this.formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void P_Articulo_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void formato()
        {
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Visible=false;

        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtUnidad.Clear();
            
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "D Criollo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "D Criollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtUnidad.Text = dataGridView1.CurrentRow.Cells["Unidad"].Value.ToString();
                cboTipoArticulo.Text = dataGridView1.CurrentRow.Cells["TipoArt"].Value.ToString();
                txtIdeArticulo.Text = dataGridView1.CurrentRow.Cells["IdeArticulo"].Value.ToString();
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
    }
}
