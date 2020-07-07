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
    public class D_Produccion
    {

        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spLisProduccion", SqlCon);
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
                SqlCommand Comando = new SqlCommand("spBuscarProduccion", SqlCon);
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
                SqlCommand Comando = new SqlCommand("spProduccionExiste", SqlCon);
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

        public string Insertar(E_Produccion Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spProduccion", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 1;
                Comando.Parameters.Add("@ideprodu", SqlDbType.Int).Value = Obj.ideprodu;
                Comando.Parameters.Add("@articuloprodu", SqlDbType.Int).Value = Obj.articuloprodu;
                Comando.Parameters.Add("@materiaprima", SqlDbType.Int).Value = Obj.materiaprima;
                Comando.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = Obj.cantidad;
                Comando.Parameters.Add("@factor", SqlDbType.Decimal).Value = Obj.factor;
                Comando.Parameters.Add("@qtyart", SqlDbType.Int).Value = Obj.qtyart;
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

        public string Actualizar(E_Produccion Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spProduccion", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 2;
                Comando.Parameters.Add("@ideprodu", SqlDbType.Int).Value = Obj.ideprodu;
                Comando.Parameters.Add("@articuloprodu", SqlDbType.Int).Value = Obj.articuloprodu;
                Comando.Parameters.Add("@materiaprima", SqlDbType.Int).Value = Obj.materiaprima;
                Comando.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = Obj.cantidad;
                Comando.Parameters.Add("@factor", SqlDbType.Decimal).Value = Obj.factor;
                Comando.Parameters.Add("@qtyart", SqlDbType.Int).Value = Obj.qtyart;
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

        public string Eliminar(E_Produccion Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spProduccion", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@ope", SqlDbType.Int).Value = 3;
                Comando.Parameters.Add("@ideprodu", SqlDbType.Int).Value = Obj.ideprodu;
                Comando.Parameters.Add("@articuloprodu", SqlDbType.Int).Value = Obj.articuloprodu;
                Comando.Parameters.Add("@materiaprima", SqlDbType.Int).Value = Obj.materiaprima;
                Comando.Parameters.Add("@cantidad", SqlDbType.Decimal).Value = Obj.cantidad;
                Comando.Parameters.Add("@factor", SqlDbType.Decimal).Value = Obj.factor;
                Comando.Parameters.Add("@qtyart", SqlDbType.Int).Value = Obj.qtyart;
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
