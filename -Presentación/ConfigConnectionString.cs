using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Presentación
{
    public static class ConfigConnectionString
    {
        public static string Cadena = ConfigurationManager.ConnectionStrings["cadenaproyecto"].ConnectionString;
    }
}
