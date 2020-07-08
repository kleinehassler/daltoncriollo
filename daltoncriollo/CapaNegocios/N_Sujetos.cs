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
    public class N_Sujetos
    {
        public static DataTable Listar()
        {
            D_Sujetos Datos = new D_Sujetos();
            return Datos.Listar();

        }

        public static DataTable Buscar(string Valor)
        {
            D_Sujetos Datos = new D_Sujetos();
            return Datos.Buscar(Valor);

        }

        public static string Insertar(string nombresujeto, string idetributario, string direccionsuje, string telefonosuje, string emailsuje, int cliente, int proveedor)
        {
            D_Sujetos Datos = new D_Sujetos();

            string Existe = Datos.Existe(nombresujeto);
            if (Existe.Equals("1"))
            {
                return nombresujeto = "Sujeto YA Existe";
            }
            else
            {
                E_Sujetos Obj = new E_Sujetos();
                Obj.nombresujeto = nombresujeto;
                Obj.idetributario = idetributario;
                Obj.direccionsuje = direccionsuje;
                Obj.telefonosuje = telefonosuje;
                Obj.emailsuje = emailsuje;
                Obj.cliente = cliente;
                Obj.proveedor = proveedor;
                return Datos.Insertar(Obj);
            }

        }

        public static string Actualizar(int idesujeto, string nombresujeto, string idetributario, string direccionsuje, string telefonosuje, string emailsuje, int cliente, int proveedor)
        {
            D_Sujetos Datos = new D_Sujetos();

            string Existe = Datos.Existe(nombresujeto);
            if (Existe.Equals("1"))
            {
                return nombresujeto = "Sujeto YA Existe";
            }
            else
            {
                E_Sujetos Obj = new E_Sujetos();
                Obj.idesujeto = idesujeto;
                Obj.nombresujeto = nombresujeto;
                Obj.idetributario = idetributario;
                Obj.direccionsuje = direccionsuje;
                Obj.telefonosuje = telefonosuje;
                Obj.emailsuje = emailsuje;
                Obj.cliente = cliente;
                Obj.proveedor = proveedor;
                return Datos.Actualizar(Obj);
            }
        }

        public static string Eliminar(int idesujeto, string nombresujeto, string idetributario, string direccionsuje, string telefonosuje, string emailsuje, int cliente, int proveedor)
        {
            D_Sujetos Datos = new D_Sujetos();
            E_Sujetos Obj = new E_Sujetos();
            Obj.idesujeto = idesujeto;
            Obj.nombresujeto = nombresujeto;
            Obj.idetributario = idetributario;
            Obj.direccionsuje = direccionsuje;
            Obj.telefonosuje = telefonosuje;
            Obj.emailsuje = emailsuje;
            Obj.cliente = cliente;
            Obj.proveedor = proveedor; 
            return Datos.Eliminar(Obj);

        }



    }
}
