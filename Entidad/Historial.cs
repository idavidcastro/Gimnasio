﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class Historial
    {

        public Plan PlanCliente { get; set; }
        public Cliente Cliente { get; set; }

        public String FechaNuevoPago { get; set; }                 
    }
}
