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
    public partial class frmIngreso : Form
    {
        private DataTable DtDetalle = new DataTable();

        public frmIngreso()
        {
            InitializeComponent();
        }


        private void Listar()
        {
            try
            {
                dataGridView1.DataSource = N_Ingreso.Listar();
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
                dataGridView1.DataSource = N_Ingreso.Buscar(txtBuscar.Text);
                this.formato();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }



        private void formato()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 150;
            dataGridView1.Columns[9].Width = 150;
            dataGridView1.Columns[10].Width = 150;
            dataGridView1.Columns[11].Width = 150;
            dataGridView1.Columns[12].Width = 150;
           
        }

        private void FormatoArticulos()
        {
            dgvArticulos.Columns[0].Visible = false;
            dgvArticulos.Columns[1].Width = 100;
            dgvArticulos.Columns[1].HeaderText = "CODIGO";
            dgvArticulos.Columns[2].Width = 200;
            dgvArticulos.Columns[2].HeaderText = "NOMBRE ARTICULO";
            dgvArticulos.Columns[3].Width = 100;
            dgvArticulos.Columns[3].HeaderText = "PRECIO";
            dgvArticulos.Columns[4].Width = 100;
            dgvArticulos.Columns[4].HeaderText = "UNIDAD";
            dgvArticulos.Columns[5].Width = 100;
            dgvArticulos.Columns[5].HeaderText = "STOCK";
            
        
        }

        private void Limpiar()
        {
            txtIdeDocumento.Clear();
            txtIdProveedor.Clear();
            txtNombreProveedor.Clear();
            txtSerie.Clear();
            txtNumComprobante.Clear();
            txtSubTotal.Text = "0.00";
            txtIVA.Text = "0.00";
            txtTotal.Text = "0.00";
            txtImpuesto.Text = "0.12";
            DtDetalle.Clear();

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

        private void CrearTabla()
        {
            this.DtDetalle.Columns.Add("idearticulo", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("codigo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.DtDetalle.Columns.Add("cantidad", System.Type.GetType("System.Int32"));
            this.DtDetalle.Columns.Add("precio", System.Type.GetType("System.Decimal"));
            this.DtDetalle.Columns.Add("importe", System.Type.GetType("System.Decimal"));
            dgvDetalle.DataSource = this.DtDetalle;

            dgvDetalle.Columns[0].Visible = false;
            dgvDetalle.Columns[1].HeaderText = "CODIGO";
            dgvDetalle.Columns[1].Width = 100;
            dgvDetalle.Columns[2].HeaderText = "ARTICULO";
            dgvDetalle.Columns[2].Width = 200;
            dgvDetalle.Columns[3].HeaderText = "CANTIDAD";
            dgvDetalle.Columns[3].Width = 100;
            dgvDetalle.Columns[4].HeaderText = "PRECIO";
            dgvDetalle.Columns[4].Width = 150;
            dgvDetalle.Columns[5].HeaderText = "IMPORTE";
            dgvDetalle.Columns[5].Width = 150;
            dgvDetalle.Columns[1].ReadOnly = true;
            dgvDetalle.Columns[2].ReadOnly = true;
            dgvDetalle.Columns[5].ReadOnly = true;
            
        }

        private void frmIngreso_Load(object sender, EventArgs e)
        {

            this.Listar();
            this.CargarBodegas();
            this.CargarDocumentos();
            this.CrearTabla();


        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            frmVista_Proveedor Vista = new frmVista_Proveedor();
            Vista.ShowDialog();
            txtIdProveedor.Text = Convert.ToString(Variables.idProveedor);
            txtNombreProveedor.Text = Variables.NombreProveedor;
        }

        private void txtCodigoArt_KeyDown(object sender, KeyEventArgs e)
        {
            try 
            {
                if (e.KeyCode== Keys.Enter)
                {
                    DataTable Tabla = new DataTable();
                    Tabla = N_Articulo.BuscarCodigoArt(txtCodigoArt.Text.Trim());
                    if (Tabla.Rows.Count<=0)
                    {
                        this.MensajeError("No Existe el Codigo de Barras del Articulo");
                    }
                    else
                    {
                        // Insertar al Detalle
                        this.AgregarDetalle(Convert.ToInt32(Tabla.Rows[0][0]), Convert.ToString(Tabla.Rows[0][1]),Convert.ToString(Tabla.Rows[0][2]), Convert.ToDecimal(Tabla.Rows[0][4]));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }

        }

        private void AgregarDetalle(int idearticulo, string codigoart, string nombreart, decimal precioart)
        {
            bool Agregar = true;
            foreach (DataRow FilaTemp in DtDetalle.Rows)
            {
                if(Convert.ToInt32(FilaTemp["idearticulo"])==idearticulo)
                {
                    Agregar = false;
                    this.MensajeError("El Articulo ya ha sido Agregado");
                }

            }
            if (Agregar)
            {
                DataRow Fila = DtDetalle.NewRow();
                Fila["idearticulo"] = idearticulo;
                Fila["codigo"] = codigoart;
                Fila["articulo"] = nombreart;
                Fila["cantidad"] = 1;
                Fila["precio"] = precioart;
                Fila["importe"] = precioart;
                this.DtDetalle.Rows.Add(Fila);
                this.CalcularTotal();

            }

        }

        private void CalcularTotal()
        {
            decimal Total = 0;
            decimal SubTotal = 0;
            if (dgvDetalle.Rows.Count == 0)
            {
                Total = 0;

            }
            else
            {

                foreach (DataRow FilaTemp in DtDetalle.Rows)
                {
                    Total = Total + Convert.ToDecimal(FilaTemp["imnporte"]);

                }
            }
            SubTotal = Total / (1 + Convert.ToDecimal(txtImpuesto.Text));
            txtSubTotal.Text = SubTotal.ToString("#0.00#");
            txtIVA.Text = (Total - SubTotal).ToString("#0.00#");

        }

        private void btnVerArticulos_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = true;

        }

        private void btnCerrarArticulos_Click(object sender, EventArgs e)
        {
            panelArticulos.Visible = false;

        }

        private void btnFiltrarArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                dgvArticulos.DataSource = N_Articulo.Buscar(txtBuscarArticulo.Text.Trim());
                this.FormatoArticulos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvArticulos_DoubleClick(object sender, EventArgs e)
        {
            int IdArticulo;
            string Codigo, Nombre;
            decimal Precio;
            IdArticulo = Convert.ToInt32(dgvArticulos.CurrentRow.Cells["idearticulo"].Value);
            Codigo = Convert.ToString(dgvArticulos.CurrentRow.Cells["codigo"].Value);
            Nombre = Convert.ToString(dgvArticulos.CurrentRow.Cells["articulo"].Value);
            Precio = Convert.ToDecimal(dgvArticulos.CurrentRow.Cells["precio"].Value);
            this.AgregarDetalle(IdArticulo, Codigo, Nombre, Precio);

        }

        private void dgvDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataRow Fila = (DataRow)DtDetalle.Rows[e.RowIndex];
            decimal Precio = Convert.ToDecimal(Fila["precio"]);
            int Cantidad = Convert.ToInt32(Fila["cantidad"]);
            Fila["importe"] = Precio * Cantidad;
            this.CalcularTotal();

        }

        private void dgvDetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.CalcularTotal();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtIdProveedor.Text == string.Empty || txtImpuesto.Text==string.Empty || txtNumComprobante.Text==string.Empty || DtDetalle.Rows.Count==0)
                {
                    this.MensajeError("Falta de Ingresar");
                    ErrorIcono.SetError(txtIdProveedor, "Selecccione un Proveedor");
                    ErrorIcono.SetError(txtImpuesto, "Ingrese un Impuesto");
                    ErrorIcono.SetError(txtNumComprobante, "Ingrese un Numero de Comprobante");
                    ErrorIcono.SetError(dgvDetalle, "Deve tener por lo Menos un Articulo");

                }
                else
                {
                    Rpta = N_Ingreso.Insertar(Convert.ToInt32(txtIdeDocumento.Text), Convert.ToInt32(cboComprobante.SelectedValue), "Ingreso", txtSerie.Text.Trim(), txtNumComprobante.Text.Trim(), Convert.ToInt32(txtIdProveedor.Text), Convert.ToDecimal(txtSubTotal.Text), Convert.ToDecimal(txtIVA.Text), Convert.ToDecimal(txtTotal.Text), Convert.ToInt32(cboBodega.SelectedValue), Variables.idUsuarios, 1, DtDetalle );
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se Registro Transaccion de Ingreso");
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

        private void cmdDelete_Click(object sender, EventArgs e)
        {

        }

        private void CargarBodegas()
        {
            try
            {
                cboBodega.DataSource = N_Ingreso.SeleccionarBodega();
                cboBodega.ValueMember = "idebodega";
                cboBodega.DisplayMember = "nombrebodega";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void CargarDocumentos()
        {
            try
            {
                cboComprobante.DataSource = N_Ingreso.SeleccionarDocumento();
                cboComprobante.ValueMember = "id";
                cboComprobante.DisplayMember = "nombre";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }
        
        
    }
}
