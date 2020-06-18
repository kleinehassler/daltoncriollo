using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Articulo
    {
        public int idearticulo { get; set; }
        public string nombreart { get; set; }
        public string codigoart { get; set; }
        public decimal precioart { get; set; }
        public int tipoart { get; set; }
        public decimal stock { get; set; }
        public string unidad { get; set; }

    }
}
