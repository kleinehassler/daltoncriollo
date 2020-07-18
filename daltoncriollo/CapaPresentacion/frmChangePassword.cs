using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CapaNegocios;
using CapaEntidad;


namespace CapaPresentacion
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Variables.NombreUsuario;
            
            
        }


        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "D Criollo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "D Criollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpiar()
        {
            txtClaveNew1.Clear();
            txtClaveNew2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClaveNew1.Text.Trim() == txtClaveNew2.Text.Trim())
                {

                    string Rpta = "";
                    Rpta = N_Usuarios.ChangePassword(Convert.ToInt32(Variables.idUsuarios), Variables.LoginActual1.Trim(), txtClaveNew1.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.Limpiar();
                        this.MensajeOk("Se Cambio la Clave del Usuario");

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                        this.Limpiar();
                    }

                }
                else
                {
                    this.MensajeError("No Coiciden las Contraseñas");
                    this.Limpiar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Close();

        }
    }
}
