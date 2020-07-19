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
    public partial class P_Produccion : Form
    {
        public P_Produccion()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Listar()
        {
            try
            {
                dataGridView1.DataSource = N_Produccion.Listar();
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
                dataGridView1.DataSource = N_Produccion.Buscar(txtBuscar.Text);
                this.formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void CargarMP()
        {
            try
            {
                cboMP.DataSource = N_Produccion.SeleccionarMP();
                cboMP.ValueMember = "idMP";
                cboMP.DisplayMember = "NombreMP";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void formato()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Width = 200;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 100;
            dataGridView1.Columns[9].Visible = false;

        }

        private void Limpiar()
        {
            txtIdeProduccion.Clear();
            txtCantMP.Clear();
            txtFactor.Clear();
            txtCantPT.Clear();
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

        private void P_Produccion_Load(object sender, EventArgs e)
        {
            this.Listar();
            this.CargarMP();
            this.CargarPT();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCual.Text = "1";
            tabControl1.SelectedIndex = 1;
            this.Limpiar();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            txtCual.Text = "2";
            tabControl1.SelectedIndex = 1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtIdeProduccion.Text = dataGridView1.CurrentRow.Cells["ideprodu"].Value.ToString();
                txtCantMP.Text = dataGridView1.CurrentRow.Cells["CantMP"].Value.ToString();
                txtFactor.Text = dataGridView1.CurrentRow.Cells["factor"].Value.ToString();
                txtCantPT.Text = dataGridView1.CurrentRow.Cells["CantidadPT"].Value.ToString();
                cboPT.Text = dataGridView1.CurrentRow.Cells["NomPT"].Value.ToString();
                cboMP.Text = dataGridView1.CurrentRow.Cells["NomMP"].Value.ToString();

            }

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txtIdeProduccion.Text = dataGridView1.CurrentRow.Cells["ideprodu"].Value.ToString();

                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Eliminar", "D Criollo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int Codigo;
                        String Rpta = "";
                        Codigo = Convert.ToInt32(txtIdeProduccion.Text);
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

        private void cmdSave_Click(object sender, EventArgs e)
        {

            if (txtCual.Text == "1")
            {
                try
                {
                    string Rpta = "";
                    if (cboPT.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(cboPT, "Seleccione el Producto Terminado");
                    }
                    else if (cboMP.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(cboMP, "Seleccione la Materia Prima");
                    }
                    else
                    {
                        Rpta = N_Produccion.Insertar(Convert.ToInt32(cboPT.SelectedValue), Convert.ToInt32(cboMP.SelectedValue), Convert.ToDecimal(txtCantMP.Text), Convert.ToDecimal(txtFactor.Text), Convert.ToInt32(txtCantPT.Text) );
 
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Registro un Nuevo Ingrediente de Produccion");
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
                    if (cboPT.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(cboPT, "Seleccione El Producto Terminado");
                    }
                    else if (cboMP.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(cboMP, "Seleccione la Materia Prima");
                    }
                    else
                    {
                        Rpta = N_Produccion.Actualizar(Convert.ToInt32(txtIdeProduccion.Text), Convert.ToInt32(cboPT.SelectedValue), Convert.ToInt32(cboMP.SelectedValue), Convert.ToDecimal(txtCantMP.Text), Convert.ToDecimal(txtFactor.Text), Convert.ToInt32(txtCantPT.Text) );
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Actualizo los Datos de Produccion");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void cmdPrint_Click(object sender, EventArgs e)
        {

        }

    }
}
