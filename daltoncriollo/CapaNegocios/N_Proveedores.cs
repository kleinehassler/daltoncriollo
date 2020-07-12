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
    public class N_Proveedores
    {

        public static DataTable Listar()
        {
            D_Proveedores Datos = new D_Proveedores();
            return Datos.Listar();

        }

        public static DataTable Buscar(string Valor)
        {
            D_Sujetos Datos = new D_Sujetos();
            return Datos.Buscar(Valor);

        }

    }
}
