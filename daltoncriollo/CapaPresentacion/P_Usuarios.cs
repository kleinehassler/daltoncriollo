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
    public partial class P_Usuarios : Form
    {
        public P_Usuarios()
        {
            InitializeComponent();
        }

        private void Listar()
        {
            try
            {
                dataGridView1.DataSource = N_Usuarios.Listar();
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
                dataGridView1.DataSource = N_Usuarios.Buscar(txtBuscar.Text);
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
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void Limpiar()
        {
            txtLogin.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
            txtClave.Clear();
            
            
            chkActivo.Checked = false;
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

        private void CargarRoles()
        {
            try
            {
                cboRol.DataSource = N_Usuarios.Seleccionar();
                cboRol.ValueMember = "codigo";
                cboRol.DisplayMember = "nombre";

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reportes.frm_rpt_ListaUsuarios Report = new Reportes.frm_rpt_ListaUsuarios();
            Report.ShowDialog();
        }

        private void P_Usuarios_Load(object sender, EventArgs e)
        {


            this.Listar();
            this.CargarRoles();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCual.Text = "1";
            tabControl1.SelectedIndex = 1;
            this.Limpiar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txtIdUsuario.Text = dataGridView1.CurrentRow.Cells["ideusu"].Value.ToString();

                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Eliminar", "D Criollo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int Codigo;
                        String Rpta = "";
                        Codigo = Convert.ToInt32(txtIdUsuario.Text);
                        Rpta = N_Usuarios.Eliminar(Codigo, " ", " ", " ", " ", 0, 0);

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
                    MessageBox.Show("Seleccione un Usuario");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }



        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            txtCual.Text = "2";
            tabControl1.SelectedIndex = 1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtIdUsuario.Text = dataGridView1.CurrentRow.Cells["ideusu"].Value.ToString();
                txtLogin.Text = dataGridView1.CurrentRow.Cells["Login"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["NombreUsuario"].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["CorreoElectronico"].Value.ToString();
                //txtClave.Text = dataGridView1.CurrentRow.Cells["Clave"].Value.ToString();
                txtClave.Text = "";
                cboRol.Text = dataGridView1.CurrentRow.Cells["RolUsuario"].Value.ToString();
                
                if (dataGridView1.CurrentRow.Cells["EsActivo"].Value.Equals("ACTIVO"))
                {
                    chkActivo.Checked = true;
                }
                else
                {
                    chkActivo.Checked = false;
                }



            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtCual.Text == "1")
            {
                try
                {
                    string Rpta = "";
                    if (txtNombre.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtNombre, "Ingrese Nombre de Usuario");
                    }
                    else if (txtEmail.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtEmail, "Ingrese Direccion de Correo Electronico");

                    }
                    else if (txtLogin.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtLogin, "Ingrese Login del Usuario");
                    }
                    else
                    {
                        Rpta = N_Usuarios.Insertar(txtNombre.Text.Trim(), txtLogin.Text.Trim(), txtClave.Text.Trim(),txtEmail.Text.Trim(), Convert.ToInt32(chkActivo.Checked), Convert.ToInt32(cboRol.SelectedValue));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Registro un Nuevo Usuario");
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
                        ErrorIcono.SetError(txtNombre, "Ingrese Nombre de Usuario");
                    }
                    else if (txtEmail.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtEmail, "Ingrese Direccion de Correo Electronico");

                    }
                    else if (txtLogin.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtLogin, "Ingrese Login del Usuario");
                    }
                    else
                    {
                        Rpta = N_Usuarios.Actualizar(Convert.ToInt32(txtIdUsuario.Text), txtNombre.Text.Trim(), txtLogin.Text.Trim(), txtClave.Text.Trim(), txtEmail.Text.Trim(), Convert.ToInt32(chkActivo.Checked), Convert.ToInt32(cboRol.SelectedValue));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Actaulizo los Datos de los Usuarios");
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

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
