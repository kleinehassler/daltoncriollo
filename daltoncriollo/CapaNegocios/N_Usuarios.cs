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
    public class N_Usuarios
    {

        public static DataTable Listar()
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Listar();

        }

        public static DataTable Buscar(string Valor)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Buscar(Valor);

        }


        public static DataTable Login(string Login, string Clave)
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Login(Login, Clave);

        }


        public static DataTable Seleccionar()
        {
            D_Usuarios Datos = new D_Usuarios();
            return Datos.Seleccionar();

        }

        public static string Insertar(string nombreusu, string loginusu, string paswoordusu, string emailusu, int activo, int tiporol)
        {
            D_Usuarios Datos = new D_Usuarios();

            string Existe = Datos.Existe(nombreusu);
            if (Existe.Equals("1"))
            {
                return nombreusu = " YA Existe";
            }
            else
            {
                E_Usuarios Obj = new E_Usuarios();
                Obj.nombreusu = nombreusu;
                Obj.loginusu = loginusu;
                Obj.paswoordusu = paswoordusu;
                Obj.emailusu = emailusu;
                Obj.activo = activo;
                Obj.tiporol = tiporol;
                return Datos.Insertar(Obj);
            }

        }

        public static string Actualizar(int ideusu, string nombreusu, string loginusu, string paswoordusu, string emailusu, int activo, int tiporol)
        {
            D_Usuarios Datos = new D_Usuarios();

            string Existe = Datos.Existe(nombreusu);
            if (Existe.Equals("1"))
            {
                return nombreusu = " YA Existe";
            }
            else
            {
                E_Usuarios Obj = new E_Usuarios();
                Obj.ideusu = ideusu;
                Obj.nombreusu = nombreusu;
                Obj.loginusu = loginusu;
                Obj.paswoordusu = paswoordusu;
                Obj.emailusu = emailusu;
                Obj.activo = activo;
                Obj.tiporol = tiporol;
                return Datos.Actualizar(Obj);
            }
        }

        public static string Eliminar(int ideusu, string nombreusu, string loginusu, string paswoordusu, string emailusu, int activo, int tiporol)
        {
            D_Usuarios Datos = new D_Usuarios();
            E_Usuarios Obj = new E_Usuarios();
            Obj.ideusu = ideusu;
            Obj.nombreusu = nombreusu;
            Obj.loginusu = loginusu;
            Obj.paswoordusu = paswoordusu;
            Obj.emailusu = emailusu;
            Obj.activo = activo;
            Obj.tiporol = tiporol;
            return Datos.Eliminar(Obj);

        }
        
        public static string ChangePassword(int ideusu, string loginusu, string paswoordusu)
        {
            D_Usuarios Datos = new D_Usuarios();
            E_Usuarios Obj = new E_Usuarios();
            Obj.ideusu = ideusu;
            Obj.loginusu = loginusu;
            Obj.paswoordusu = paswoordusu;
            return Datos.ChangePassword(Obj);
            
        }


    }
}
