using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string Edad { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Direccion { get; set; }
        public Plan PlanCliente { get; set; }
        public string FechaIngreso { get; set; }

    }
}
