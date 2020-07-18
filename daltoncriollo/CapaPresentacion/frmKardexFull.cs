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
    public partial class frmKardexFull : Form
    {
        public frmKardexFull()
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

        private void formato()
        {
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;

        }
        
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "D Criollo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "D Criollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void cmdPrint_Click(object sender, EventArgs e)
        {


            try
            {
                Variables.idArtKardex = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idearticulo"].Value);
                Reportes.frm_Rpt_KardexFull rpt = new Reportes.frm_Rpt_KardexFull();
                rpt.ShowDialog();


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }



        }

        private void frmKardexFull_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();

        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    
    
    
    }
}
