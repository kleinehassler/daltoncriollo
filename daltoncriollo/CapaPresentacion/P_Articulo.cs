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

        private void P_Articulo_Load(object sender, EventArgs e)
        {
            LisArt();

        }

        E_Articulo objEntidad = new E_Articulo();
        N_Articulo objNegocio = new N_Articulo();

        void LisArt()
        {
            DataTable dt = objNegocio.N_LisArt();
            dataGridView1.DataSource = dt;

        }
    }
}
