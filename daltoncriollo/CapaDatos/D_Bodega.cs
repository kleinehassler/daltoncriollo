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
    public class D_Bodega
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spLisBodegas", SqlCon);
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


        public string Insertar(E_Bodega Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spBodega", SqlCon);
                Comando.CommandType=CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value=1;
                Comando.Parameters.Add("@idBod", SqlDbType.Int).Value=Obj.idebodega;
                Comando.Parameters.Add("@nombod", SqlDbType.VarChar).Value=Obj.nombrebodega;
                Comando.Parameters.Add("@dirbod", SqlDbType.VarChar).Value=Obj.direccion;
                Comando.Parameters.Add("@resbod",SqlDbType.Int).Value=Obj.responsable;
                
                SqlCon.Open();
                Rpta=Comando.ExecuteNonQuery()==1 ? "OK" : "No se INSERTO Registro";

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


        public string Actualizar(E_Bodega Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spBodega", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 2;
                Comando.Parameters.Add("@idBod", SqlDbType.Int).Value = Obj.idebodega;
                Comando.Parameters.Add("@nombod", SqlDbType.VarChar).Value = Obj.nombrebodega;
                Comando.Parameters.Add("@dirbod", SqlDbType.VarChar).Value = Obj.direccion;
                Comando.Parameters.Add("@resbod", SqlDbType.Int).Value = Obj.responsable;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizo Registro";

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


        public string Eliminar(E_Bodega Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spBodega", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 3;
                Comando.Parameters.Add("@idBod", SqlDbType.Int).Value = Obj.idebodega;
                Comando.Parameters.Add("@nombod", SqlDbType.VarChar).Value = Obj.nombrebodega;
                Comando.Parameters.Add("@dirbod", SqlDbType.VarChar).Value = Obj.direccion;
                Comando.Parameters.Add("@resbod", SqlDbType.Int).Value = Obj.responsable;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se Elimino Registro";

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
