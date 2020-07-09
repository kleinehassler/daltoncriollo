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
    public partial class P_Bodega : Form
    {

        public P_Bodega()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                dataGridView1.DataSource = N_Bodega.Listar();
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
                dataGridView1.DataSource = N_Bodega.Buscar(txtBuscar.Text);
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
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Visible = false;
        }
        
        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            //cboResponsable.Clear();
            ErrorIcono.Clear();

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
            Reportes.frm_rptListaBodega Reporte = new Reportes.frm_rptListaBodega();
            Reporte.ShowDialog();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCual.Text = "1";
            tabControl1.SelectedIndex = 1;
            this.Limpiar();
        }

        private void CargasrResponsable()
        {
            try
            {
                cboResponsable.DataSource = N_Bodega.Seleccionar();
                cboResponsable.ValueMember = "idResponsable";
                cboResponsable.DisplayMember = "NombreResponsable";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
        
        private void P_Bodega_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargasrResponsable();

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txtCodigo.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Eliminar", "D Criollo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int Codigo;
                        String Rpta = "";
                        Codigo = Convert.ToInt32(txtCodigo.Text);
                        Rpta = N_Bodega.Eliminar(Codigo, " ", " ", 0);

                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Registro Eliminado");
                        }

                        else
                        {
                            this.MensajeError(Rpta);
                        }
                    }
                    this.Listar();
                }
                else
                {
                    MessageBox.Show("Seleccione una Bodega");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            txtCual.Text = "2";
            tabControl1.SelectedIndex = 1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["NombreBodega"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                cboResponsable.Text = dataGridView1.CurrentRow.Cells["Responsable"].Value.ToString();
                
            }

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {

            if (txtCual.Text == "1")
            {
                try
                {
                    string Rpta = "";
                    if (txtNombre.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtNombre, "Ingrese Nombre de Bodega");
                    }
                    else if (txtDireccion.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtDireccion, "Ingrese Direccion Bodega");
                    }
                    else
                    {
                        Rpta = N_Bodega.Insertar(txtNombre.Text.Trim(), txtDireccion.Text.Trim(), Convert.ToInt32(cboResponsable.SelectedValue));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Registro un Nueva Bodega");
                            this.Limpiar();
                            this.Listar();
                            tabControl1.SelectedIndex = 0;
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);

                }
            }
            if (txtCual.Text == "2")
            {
                try
                {
                    string Rpta = "";
                    if (txtNombre.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtNombre, "Ingrese Nombre de Bodega");
                    }
                    else if (txtDireccion.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtDireccion, "Ingrese Direccion de Bodega");
                    }
                    else
                    {
                        Rpta = N_Bodega.Actualizar(Convert.ToInt32(txtCodigo.Text), txtNombre.Text.Trim(), txtDireccion.Text.Trim(), Convert.ToInt32(cboResponsable.SelectedValue) );
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Actaulizo los Datos de la Bodega");
                            this.Limpiar();
                            this.Listar();
                            tabControl1.SelectedIndex = 0;
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);

                }
            }

        }

        private void cboResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
    }
}
