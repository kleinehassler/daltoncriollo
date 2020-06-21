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
    public class D_Articulo
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqldcriollo"].ConnectionString);

        public DataTable D_LisArt()
        {
            SqlCommand cmd = new SqlCommand("spLisArt", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void 

    }


}
