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

        private void P_Articulo_Load(object sender, EventArgs e)
        {
            LisArt();

        }

        E_Articulo objEntidad = new E_Articulo();
        N_Articulo objNegocio = new N_Articulo();

        void LisArt()
        {
            DataTable dt = objNegocio.N_LisArt();
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = " ";
            txtNombre.Text = " ";
            txtPrecio.Text = "0.00";
            txtUnidad.Text = "Unidad";

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
    }
}
