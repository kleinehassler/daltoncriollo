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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Tabla = new DataTable();
                Tabla=N_Usuarios.Login(txtLogin.Text.Trim(), txtPass.Text.Trim());
                if (Tabla.Rows.Count<=0)
                {
                    MessageBox.Show("No Existe Login o Clave Ingresada","Acceso",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                else
                {
                    if(Convert.ToBoolean(Tabla.Rows[0][6])==false)
                    {
                        MessageBox.Show("Usuario NO ACTIVO","Acceso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        frmSistema Frm = new frmSistema();
                        Variables.idUsuarios = Convert.ToInt32(Tabla.Rows[0][5]);
                        Frm.idUsuario=Convert.ToInt32(Tabla.Rows[0][5]);
                        Frm.idRol=Convert.ToInt32(Tabla.Rows[0][7]);
                        Frm.NombreUsr=Convert.ToString(Tabla.Rows[0][1]);
                        Frm.LoginUsr=Convert.ToString(Tabla.Rows[0][0]);
                        Frm.RolNombre=Convert.ToString(Tabla.Rows[0][4]);
                        Frm.EstadoUsr=Convert.ToBoolean(Tabla.Rows[0][6]);
                        Frm.Show();
                        this.Hide();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
