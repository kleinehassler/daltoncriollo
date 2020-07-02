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
    public class N_Bodega 
    {
        public static DataTable Listar()
        {
            D_Bodega Datos = new D_Bodega();
            return Datos.Listar();

        }

        public static DataTable Buscar(string Valor)
        {
            D_Bodega Datos = new D_Bodega();
            return Datos.Buscar(Valor);

        }


        public static string Insertar(string nombrebodega, string direccion, int responsable)
        {
           D_Bodega Datos = new D_Bodega();
           
           string Existe = Datos.Existe(nombrebodega);
           if (Existe.Equals("1"))
           {
               return nombrebodega = "Bodega YA Existe";
           }
           else
           {
               E_Bodega Obj = new E_Bodega();
               Obj.nombrebodega = nombrebodega;
               Obj.direccion = direccion;
               Obj.responsable = responsable;
               return Datos.Insertar(Obj);
           }

        }

        public static string Actualizar(int idebodega, string nombrebodega, string direccion,  int responsable)
        {
            D_Bodega Datos = new D_Bodega();
           
           string Existe = Datos.Existe(nombrebodega);
           if (Existe.Equals("1"))
           {
               return nombrebodega = "Bodega YA Existe";
           }
           else
           {  
                E_Bodega Obj = new E_Bodega();
                Obj.idebodega = idebodega;
                Obj.nombrebodega = nombrebodega;
                Obj.direccion = direccion;
                Obj.responsable = responsable;
                return Datos.Actualizar(Obj);
            }
        }

        public static string Eliminar(int idebodega, string nombrebodega, string direccion, int responsable)
        {
            E_Bodega Obj = new E_Bodega();
            Obj.idebodega = idebodega;
            Obj.nombrebodega = nombrebodega;
            Obj.direccion = direccion;
            Obj.responsable = responsable;
            return Datos.Eliminar(Obj);

        }




    }
}
