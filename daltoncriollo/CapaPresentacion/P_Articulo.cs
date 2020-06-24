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
            dataGridView1.Columns[6].Visible = false;

        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtUnidad.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            txtCual.Text = "2";
            tabControl1.SelectedIndex = 1;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtCodigo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtUnidad.Text = dataGridView1.CurrentRow.Cells["Unidad"].Value.ToString();
                txtTipoArt.Text = dataGridView1.CurrentRow.Cells["ntipoart"].Value.ToString();
                txtIdeArticulo.Text = dataGridView1.CurrentRow.Cells["IdeArticulo"].Value.ToString();
                if (dataGridView1.CurrentRow.Cells["ntipoart"].Value.Equals(1))
                {
                    rbPT.Select();
                }
                else
                {
                    rbMP.Select();
                }

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
                        ErrorIcono.SetError(txtNombre, "Ingrese Nombre del Articulo");
                    }else if(txtPrecio.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtPrecio, "Ingrese Precio de Articulo");
                    }
                    else if (txtUnidad.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtUnidad, "Ingrese Unidad del Articulo");
                    }
                    else
                    {
                        Rpta = N_Articulo.Insertar(txtNombre.Text.Trim(), txtCodigo.Text.Trim(),Convert.ToDecimal( txtPrecio.Text), Convert.ToInt32(txtTipoArt.Text) , 0, txtUnidad.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Registro un Nuevo Articulo");
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
                        ErrorIcono.SetError(txtNombre, "Ingrese Nombre del Articulo");
                    }
                    else if (txtPrecio.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtPrecio, "Ingrese Precio de Articulo");
                    }
                    else if (txtUnidad.Text == string.Empty)
                    {
                        this.MensajeError("Falta de Ingresar");
                        ErrorIcono.SetError(txtUnidad, "Ingrese Unidad del Articulo");
                    }
                    else
                    {
                        Rpta = N_Articulo.Actualizar(Convert.ToInt32(txtIdeArticulo.Text), txtNombre.Text.Trim(), txtCodigo.Text.Trim(), Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtTipoArt.Text), 0, txtUnidad.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se Actaulizo los Datos del Articulo");
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

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    txtIdeArticulo.Text = dataGridView1.CurrentRow.Cells["IdeArticulo"].Value.ToString();

                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Eliminar", "D Criollo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int Codigo;
                        String Rpta = "";
                        Codigo = Convert.ToInt32(txtIdeArticulo.Text);
                        Rpta = N_Articulo.Elliminar(Codigo, " ", " ", 0, 0, 0, " ");

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCual.Text = "1";
            tabControl1.SelectedIndex = 1;
            this.Limpiar();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbPT_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoArt.Text = "1";
        }

        private void rbMP_CheckedChanged(object sender, EventArgs e)
        {
            txtTipoArt.Text = "2";
        }

        private void txtTipoArt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
