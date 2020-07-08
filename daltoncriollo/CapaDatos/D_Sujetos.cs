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
    public class D_Sujetos
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spLisSujetos", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

        }

        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spBuscarSujeto", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

        }
        
        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spSujetoExiste", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.Int).Value = Valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Insertar(E_Sujetos Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spSujeto", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 1;
                Comando.Parameters.Add("@idSuj", SqlDbType.Int).Value = Obj.idesujeto;
                Comando.Parameters.Add("@sname", SqlDbType.VarChar).Value = Obj.nombresujeto;
                Comando.Parameters.Add("@sruc", SqlDbType.VarChar).Value = Obj.idetributario;
                Comando.Parameters.Add("@sdir", SqlDbType.VarChar).Value = Obj.direccionsuje;
                Comando.Parameters.Add("@stel", SqlDbType.VarChar).Value = Obj.telefonosuje;
                Comando.Parameters.Add("@semail", SqlDbType.VarChar).Value = Obj.emailsuje;
                Comando.Parameters.Add("@siscliente", SqlDbType.Int).Value = Obj.cliente;
                Comando.Parameters.Add("@sisproveedor", SqlDbType.Int).Value = Obj.proveedor;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se INSERTO Registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Actualizar(E_Sujetos Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spSujeto", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 2;
                Comando.Parameters.Add("@idSuj", SqlDbType.Int).Value = Obj.idesujeto;
                Comando.Parameters.Add("@sname", SqlDbType.VarChar).Value = Obj.nombresujeto;
                Comando.Parameters.Add("@sruc", SqlDbType.VarChar).Value = Obj.idetributario;
                Comando.Parameters.Add("@sdir", SqlDbType.VarChar).Value = Obj.direccionsuje;
                Comando.Parameters.Add("@stel", SqlDbType.VarChar).Value = Obj.telefonosuje;
                Comando.Parameters.Add("@semail", SqlDbType.VarChar).Value = Obj.emailsuje;
                Comando.Parameters.Add("@siscliente", SqlDbType.Int).Value = Obj.cliente;
                Comando.Parameters.Add("@sisproveedor", SqlDbType.Int).Value = Obj.proveedor; 
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se ACTUALIZO Registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Eliminar(E_Sujetos Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spSujeto", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 3;
                Comando.Parameters.Add("@idSuj", SqlDbType.Int).Value = Obj.idesujeto;
                Comando.Parameters.Add("@sname", SqlDbType.VarChar).Value = Obj.nombresujeto;
                Comando.Parameters.Add("@sruc", SqlDbType.VarChar).Value = Obj.idetributario;
                Comando.Parameters.Add("@sdir", SqlDbType.VarChar).Value = Obj.direccionsuje;
                Comando.Parameters.Add("@stel", SqlDbType.VarChar).Value = Obj.telefonosuje;
                Comando.Parameters.Add("@semail", SqlDbType.VarChar).Value = Obj.emailsuje;
                Comando.Parameters.Add("@siscliente", SqlDbType.Int).Value = Obj.cliente;
                Comando.Parameters.Add("@sisproveedor", SqlDbType.Int).Value = Obj.proveedor;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se ELIMINO Registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        

        
    }
}
