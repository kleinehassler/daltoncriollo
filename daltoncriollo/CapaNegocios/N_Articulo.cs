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
    public class N_Articulo
    {
        public static DataTable Listar()
        {
            D_Articulo Datos = new D_Articulo();
            return Datos.Listar();

        }

        public static DataTable Buscar(string Valor)
        {
            D_Articulo Datos = new D_Articulo();
            return Datos.Buscar(Valor);

        }


        public static string Insertar(string nombreart, string codigoart, decimal precioart, int tipoart, decimal stock, string unidad)
        {
           D_Articulo Datos = new D_Articulo();
           
           string Existe = Datos.Existe(nombreart);
           if (Existe.Equals("1"))
           {
               return nombreart = "Articulo YA Existe";
           }
           else
           {
               E_Articulo Obj = new E_Articulo();
               Obj.nombreart = nombreart;
               Obj.codigoart = codigoart;
               Obj.precioart = precioart;
               Obj.tipoart = tipoart;
               Obj.stock = stock;
               Obj.unidad = unidad;
               return Datos.Insertar(Obj);
           }

        }

        public static string Actualizar(int idearticulo, string nombreart, string codigoart, decimal precioart, int tipoart, decimal stock, string unidad)
        {
            D_Articulo Datos = new D_Articulo();
           
           string Existe = Datos.Existe(nombreart);
           if (Existe.Equals("1"))
           {
               return nombreart = "Articulo YA Existe";
           }
           else
           {  
                E_Articulo Obj = new E_Articulo();
                Obj.idearticulo = idearticulo;
                Obj.nombreart = nombreart;
                Obj.codigoart = codigoart;
                Obj.precioart = precioart;
                Obj.tipoart = tipoart;
                Obj.stock = stock;
                Obj.unidad = unidad;
                return Datos.Actualizar(Obj);
            }
        }

        public static string Elliminar(int idearticulo, string nombreart, string codigoart, decimal precioart, int tipoart, decimal stock, string unidad)
        {
            D_Articulo Datos = new D_Articulo();
            E_Articulo Obj = new E_Articulo();
            Obj.idearticulo = idearticulo;
            Obj.nombreart = nombreart;
            Obj.codigoart = codigoart;
            Obj.precioart = precioart;
            Obj.tipoart = tipoart;
            Obj.stock = stock;
            Obj.unidad = unidad;
            return Datos.Eliminar(Obj);

        }


    }
}
