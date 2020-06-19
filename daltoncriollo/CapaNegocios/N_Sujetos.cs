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
    public class N_Sujetos
    {
        D_Sujetos objdato = new D_Sujetos();
        public DataTable N_LisSujeto()
        {
            return objdato.D_LisSujetos();
        }

    }
}
