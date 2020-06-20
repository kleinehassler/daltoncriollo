using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Configuration;

using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class D_Usuarios
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqldcriollo"].ConnectionString);

        public DataTable D_LisUsuarios()
        {
            SqlCommand cmd = new SqlCommand("spLisUsuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
