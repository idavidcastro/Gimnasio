

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class Historial
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
     
        public Plan PlanCliente { get; set; }
        public string FechaIngreso { get; set; }


    }
}
