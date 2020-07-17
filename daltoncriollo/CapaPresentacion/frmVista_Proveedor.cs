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
    public partial class frmVista_Proveedor : Form
    {
        public frmVista_Proveedor()
        {
            InitializeComponent();
        }


        private void Listar()
        {
            try
            {
                dataGridView1.DataSource = N_Proveedores.Listar();
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
                dataGridView1.DataSource = N_Sujetos.Buscar(txtBuscar.Text);
                this.formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void formato()
        {
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Visible = false;

        }


        private void frmVista_Proveedor_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.idProveedor = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idesujeto"].Value);
            Variables.NombreProveedor = Convert.ToString(dataGridView1.CurrentRow.Cells["ApeNom"].Value);
            this.Close();

        }
    }
}
