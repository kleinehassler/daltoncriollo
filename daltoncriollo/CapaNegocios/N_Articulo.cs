using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocios
{
    public class N_Articulo
    {
        D_Articulo objdato = new D_Articulo();
        public DataTable N_LisArt()
        {
            return objdato.D_LisArt();
        }

    }
}
