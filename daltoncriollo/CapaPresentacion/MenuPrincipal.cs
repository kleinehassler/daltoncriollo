using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            smDatos.Visible = true;
            smMoviento.Visible = false;
            smResumen.Visible = false;
            smUsuario.Visible = false;

        }

        private void btnBodegas_Click(object sender, EventArgs e)
        {
            smDatos.Visible = false;
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            smDatos.Visible = false;
            AbrirFormHija(new P_Articulo());
        }

        private void btnSujeto_Click(object sender, EventArgs e)
        {
            smDatos.Visible = false;
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            smDatos.Visible = false;
        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            smMoviento.Visible = true;
            smDatos.Visible = false;
            smResumen.Visible = false;
            smUsuario.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            smMoviento.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            smMoviento.Visible = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            smMoviento.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            smMoviento.Visible = false;
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            smResumen.Visible = true;
            smDatos.Visible = false;
            smMoviento.Visible = false;
            smUsuario.Visible = false;

        }

        private void btnKardex_Click(object sender, EventArgs e)
        {
            smResumen.Visible = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            smResumen.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            smResumen.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            smResumen.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            smUsuario.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            smUsuario.Visible = false;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            smUsuario.Visible = true;
            smDatos.Visible = false;
            smMoviento.Visible = false;
            smResumen.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();


        }

        private void logo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Inicio());
        }

    }
}
