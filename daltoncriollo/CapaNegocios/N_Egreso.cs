﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocios
{
    public class N_Egreso
    {
        
        public static DataTable Listar()
        {
            D_Egreso Datos = new D_Egreso();
            return Datos.Listar();

        }

        public static DataTable Buscar(string Valor)
        {
            D_Egreso Datos = new D_Egreso();
            return Datos.Buscar(Valor);

        }

        public static string Insertar(int idedocumento, int tipodocumento, string nombredocu, string seriedocu, string numdocu, int sujeto, decimal subtotal, decimal iva, decimal total, int bodega, int vendedor, int estado, DataTable Detalles)
        {
            D_Egreso Datos = new D_Egreso();
            E_Egreso Obj = new E_Egreso();
            Obj.idedocumento = idedocumento;
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

        public static string Anular(int IdEgreso)
        {
            D_Egreso Datos = new D_Egreso();
            return Datos.Anular(IdEgreso);
        }

    }
}
