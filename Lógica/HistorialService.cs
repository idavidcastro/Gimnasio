using Datos;
using Entidad;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class HistorialServices
    {
         HistorialRepository historialrepository; 
        ConnectionManager connectionManager;
        //List<Cliente> clientes;
        public HistorialServices(string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            historialrepository = new HistorialRepository(connectionManager.Connetion);

        }
        public string GuardarHistorial(Historial historial)
        {
            try
            {
                connectionManager.Open();

                if (historialrepository.BuscarHistorialPorIdentificacion(historial.Identificacion) == null)
                {
                   historialrepository.GuardarHistorialRep(historial);
                    return "El nuevo Historial ha sido registrado correctamente!";
                }
                else
                {
                    return $"El Historial con la identificacion {historial.Identificacion}, ya se encuentra registrado";
                }
            }
            catch (Exception exception)
            {
                return "Se presentó el siguiente error:" + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }

        }

        }
    }

