using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

namespace CapaEntidad
{
    public class E_Egreso
    {
        public int idedocumento { get; set; }
        public int tipodocu { get; set; }
        public string nombredocu { get; set; }
        public string seriedocu { get; set; }
        public string numdocu { get; set; }
        public int sujeto { get; set; }
        public DateTime fecha { get; set; }
        public decimal subtotal { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public int bodega { get; set; }
        public int vendedor { get; set; }
        public int estado { get; set; }
        public DataTable Detalle { get; set; }

        
    }
}
