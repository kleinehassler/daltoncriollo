using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Produccion
    {
        public int ideprodu { get; set; }
        public int articuloprodu { get; set; }
        public int materiaprima { get; set; }
        public decimal cantidad { get; set; }
        public decimal factor { get; set; }
        public int qtyart { get; set; }
    }
}
