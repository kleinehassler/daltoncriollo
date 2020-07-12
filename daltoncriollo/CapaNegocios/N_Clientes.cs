using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;


namespace CapaNegocios
{
    public class N_Clientes
    {

        public static DataTable Listar()
        {
            D_Clientes Datos = new D_Clientes();
            return Datos.Listar();

        }

        public static DataTable Buscar(string Valor)
        {
            D_Sujetos Datos = new D_Sujetos();
            return Datos.Buscar(Valor);

        }

    }
}
