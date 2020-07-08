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
    public partial class P_Sujetos : Form
    {
        public P_Sujetos()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                dataGridView1.DataSource = N_Sujetos.Listar();
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

        private void P_Articulo_Load(object sender, EventArgs e)
        {
            this.Listar();
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

        private void Limpiar()
        {
            txtNombre.Clear();
            txtTributario.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            chkCliente.Checked = false;
            chkProveedor.Checked = false;
            txtIdSujeto.Clear();

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


        private void P_Sujetos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reportes.frm_rptListaSujetos Report = new Reportes.frm_rptListaSujetos();
            Report.ShowDialog();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtCual.Text = "1";
            tabControl1.SelectedIndex = 1;
            this.Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txtIdSujeto.Text = dataGridView1.CurrentRow.Cells["idesujeto"].Value.ToString();

                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Eliminar", "D Criollo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int Codigo;
                        String Rpta = "";
                        Codigo = Convert.ToInt32(txtIdSujeto.Text);
                        Rpta = N_Sujetos.Eliminar(Codigo, " ", " ", " ", " ", " ", 0, 0);

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
                    MessageBox.Show("Seleccione un Articulo");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }



        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            txtCual.Text = "2";
            tabControl1.SelectedIndex = 1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtIdSujeto.Text = dataGridView1.CurrentRow.Cells["idesujeto"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["ApeNom"].Value.ToString();
                txtTributario.Text = dataGridView1.CurrentRow.Cells["CedulaRUC"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                
                if (dataGridView1.CurrentRow.Cells["EsCliente"].Value.Equals("Cliente"))
                {
                    chkCliente.Checked = true;
                }
                else
                {
                    chkCliente.Checked = false;
                }


                if (dataGridView1.CurrentRow.Cells["EsProveedor"].Value.Equals("Proveedor"))
                {
                    chkProveedor.Checked = true;
                }
                else
                {
                    chkProveedor.Checked = false;
                }

            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtCual.Text == "1")
            {
                try
                {
                    string Rpta = "";
                    if (txtNombre.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtNombre, "Ingrese Nombre del Sujeto");
                    }
                    else if (txtTributario.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtTributario, "Ingrese la Identificacion Tributaria");
                    }
                    else if (txtEmail.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtEmail, "Ingrese Direccion de Correo Electronico");
                    }
                    else
                    {
                        Rpta = N_Sujetos.Insertar(txtNombre.Text.Trim(), txtTributario.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtEmail.Text.Trim(), Convert.ToInt32(chkCliente.Checked), Convert.ToInt32(chkProveedor.Checked));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Registro un Nuevo Sujeto");
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
                        ErrorIcono.SetError(txtNombre, "Ingrese Nombre del Sujeto");
                    }
                    else if (txtTributario.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtTributario, "Ingrese la Identificacion Tributaria");
                    }
                    else if (txtEmail.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtEmail, "Ingrese Direccion de Correo Electronico");
                    }
                    else
                    {
                        Rpta = N_Sujetos.Actualizar(Convert.ToInt32(txtIdSujeto.Text), txtNombre.Text.Trim(), txtTributario.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtEmail.Text.Trim(), Convert.ToInt32(chkCliente.Checked), Convert.ToInt32(chkProveedor.Checked));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Actaulizo los Datos del Sujeto");
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
    }
}
