using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class D_Factura
    {

        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Factura_listar", SqlCon);
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
                SqlCommand Comando = new SqlCommand("factura_buscar", SqlCon);
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

        public DataTable BuscarArticuloPTCodigo(string Valor)
        {
            // Buscar Articulos en por Codigo de Barras 
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_buscar_codigo_pt", SqlCon);
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

        public DataTable ListarDetalle(int IdDocumento)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("factura_listar_detalle", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idfactura", SqlDbType.Int).Value = IdDocumento;
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

        public DataTable SeleccionarBodega()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spBodega_Seleccionar", SqlCon);
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

        public DataTable SeleccionarDocumento()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("spDocumentos_Seleccionar", SqlCon);
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

        public string Insertar(E_Factura Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("factura_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idusuario", SqlDbType.Int).Value = Obj.vendedor;
                Comando.Parameters.Add("@idcliente", SqlDbType.Int).Value = Obj.sujeto;
                Comando.Parameters.Add("@serie_comprobante", SqlDbType.VarChar).Value = Obj.seriedocu;
                Comando.Parameters.Add("@num_comprobante", SqlDbType.VarChar).Value = Obj.numdocu;
                Comando.Parameters.Add("@subtotal", SqlDbType.Decimal).Value = Obj.subtotal;
                Comando.Parameters.Add("@iva", SqlDbType.Decimal).Value = Obj.iva;
                Comando.Parameters.Add("@total", SqlDbType.Decimal).Value = Obj.total;
                Comando.Parameters.Add("@bodega", SqlDbType.Int).Value = Obj.bodega;
                Comando.Parameters.Add("@detalle", SqlDbType.Structured).Value = Obj.Detalle;
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = "OK";

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

        public string Anular(int idfactura)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("factura_anular", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idfactura", SqlDbType.Int).Value = idfactura;
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = "OK";

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
