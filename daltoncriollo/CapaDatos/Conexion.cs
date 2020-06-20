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
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "DCRIOLLO";
            this.Servidor = "localhost";
            this.Usuario="sa";
            this.Clave="123456";
            this.Seguridad=true;
           
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            { 
               Cadena.ConnectionString="Server = "+this.Servidor+"; Database = "+ this.Base+";";
                if(this.Seguridad)
                { 
                    Cadena.ConnectionString=Cadena.ConnectionString + " Integrated Security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString=Cadena.ConnectionString + " User id = " + this.Usuario+"; Password = "+ this.Clave+";";
                }
            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;

        }

        public static Conexion getInstancia()
        {
            if(con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
