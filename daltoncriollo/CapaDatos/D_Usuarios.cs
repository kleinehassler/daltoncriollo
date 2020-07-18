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


        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spLisUsuarios", SqlCon);
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
                SqlCommand Comando = new SqlCommand("spBuscarUsuario", SqlCon);
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


        public DataTable Login(string Login, string Clave)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spUsuario_Login", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@login", SqlDbType.VarChar).Value = Login;
                Comando.Parameters.Add("@clave", SqlDbType.VarChar).Value = Clave;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();

            }

        }


        public DataTable Seleccionar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spRoles_Seleccionar", SqlCon);
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

        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spArticuloExiste", SqlCon);
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

        public string Insertar(E_Usuarios Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spUsuarios", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 1;
                Comando.Parameters.Add("@ideusr", SqlDbType.Int).Value = Obj.ideusu;
                Comando.Parameters.Add("@uname", SqlDbType.VarChar).Value = Obj.nombreusu;
                Comando.Parameters.Add("@ulogin", SqlDbType.VarChar).Value = Obj.loginusu;
                Comando.Parameters.Add("@upass", SqlDbType.VarChar).Value = Obj.paswoordusu;
                Comando.Parameters.Add("@umail", SqlDbType.VarChar).Value = Obj.emailusu;
                Comando.Parameters.Add("@uactivo", SqlDbType.Int).Value = Obj.activo;
                Comando.Parameters.Add("@utiporol", SqlDbType.Int).Value = Obj.tiporol;
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

        public string Actualizar(E_Usuarios Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spUsuarios", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 2;
                Comando.Parameters.Add("@ideusr", SqlDbType.Int).Value = Obj.ideusu;
                Comando.Parameters.Add("@uname", SqlDbType.VarChar).Value = Obj.nombreusu;
                Comando.Parameters.Add("@ulogin", SqlDbType.VarChar).Value = Obj.loginusu;
                Comando.Parameters.Add("@upass", SqlDbType.VarChar).Value = Obj.paswoordusu;
                Comando.Parameters.Add("@umail", SqlDbType.VarChar).Value = Obj.emailusu;
                Comando.Parameters.Add("@uactivo", SqlDbType.Int).Value = Obj.activo;
                Comando.Parameters.Add("@utiporol", SqlDbType.Int).Value = Obj.tiporol;
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

        public string Eliminar(E_Usuarios Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spUsuarios", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 3;
                Comando.Parameters.Add("@ideusr", SqlDbType.Int).Value = Obj.ideusu;
                Comando.Parameters.Add("@uname", SqlDbType.VarChar).Value = Obj.nombreusu;
                Comando.Parameters.Add("@ulogin", SqlDbType.VarChar).Value = Obj.loginusu;
                Comando.Parameters.Add("@upass", SqlDbType.VarChar).Value = Obj.paswoordusu;
                Comando.Parameters.Add("@umail", SqlDbType.VarChar).Value = Obj.emailusu;
                Comando.Parameters.Add("@uactivo", SqlDbType.Int).Value = Obj.activo;
                Comando.Parameters.Add("@utiporol", SqlDbType.Int).Value = Obj.tiporol;
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

        public string ChangePassword(E_Usuarios Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spUsuario_ChangePassw", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                
                Comando.Parameters.Add("@ideusr", SqlDbType.Int).Value = Obj.ideusu;
                Comando.Parameters.Add("@login", SqlDbType.VarChar).Value = Obj.loginusu;
                Comando.Parameters.Add("@newpw", SqlDbType.VarChar).Value = Obj.paswoordusu;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se CAMBIO CLAVE";

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
