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
    public class N_Ingreso
    {
        
        public static DataTable Listar()
        {
            D_Ingreso Datos = new D_Ingreso();
            return Datos.Listar();

        }

        public static DataTable Buscar(string Valor)
        {
            D_Ingreso Datos = new D_Ingreso();
            return Datos.Buscar(Valor);

        }
        
        public static DataTable BuscarArticuloPTCodigo(string Valor)
        {
            D_Ingreso Datos = new D_Ingreso();
            return Datos.BuscarArticuloPTCodigo(Valor);

        }

        public static DataTable ListarDetalle(int idedetalle)
        {
            D_Ingreso Datos = new D_Ingreso();
            return Datos.ListarDetalle(idedetalle);

        }

        public static DataTable SeleccionarBodega()
        {
            D_Ingreso Datos = new D_Ingreso();
            return Datos.SeleccionarBodega();

        }

        public static DataTable SeleccionarDocumento()
        {
            D_Ingreso Datos = new D_Ingreso();
            return Datos.SeleccionarDocumento();

        }

        public static string Insertar(int tipodocumento, string nombredocu, string seriedocu, string numdocu, int sujeto, decimal subtotal, decimal iva, decimal total, int bodega, int vendedor, int estado, DataTable Detalles)
        {
            //int idedocumento, 
            D_Ingreso Datos = new D_Ingreso();
            E_Ingreso Obj = new E_Ingreso();
            //Obj.idedocumento = idedocumento;
            Obj.tipodocu = tipodocumento;
            Obj.nombredocu = nombredocu;
            Obj.seriedocu = seriedocu;
            Obj.numdocu = numdocu;
            Obj.sujeto = sujeto;
            Obj.subtotal = subtotal;
            Obj.iva = iva;
            Obj.total = total;
            Obj.bodega = bodega;
            Obj.vendedor = vendedor;
            Obj.estado = estado;
            Obj.Detalle = Detalles;
            return Datos.Insertar(Obj);
            
        }

        public static string Anular(int IdIngreso)
        {
            D_Ingreso Datos = new D_Ingreso();
            return Datos.Anular(IdIngreso);
        }

    }
}
