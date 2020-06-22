using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Usuarios
    {
        public int ideusu { get; set; }
        public string nombreusu { get; set; }
        public string loginusu { get; set; }
        public string paswoordusu { get; set; }
        public string emailusu { get; set; }
        public int activo { get; set; }
        public int tiporol { get; set; }
    }
}
