using Datos;
using Entidad;
using System;

using System.Collections.Generic;

namespace Lógica
{
    public class HistorialServices
    {
        HistorialRepository historialrepository;
        ConnectionManager connectionManager;
        private object identificacion;

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

        public object GetIdentificacion()
        {
            return identificacion;
        }


        public ConsultaReponseHistorial ConsultarHistorial(string identificacion)
        {
            try
            {
                connectionManager.Open();

                return new ConsultaReponseHistorial(historialrepository.ConsultarHistorial(identificacion));
            }
            catch (Exception exception)
            {
                return new ConsultaReponseHistorial("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }



        public class ConsultaReponseHistorial
        {
            public List<Historial> Historiales { get; set; }
            public string Mensaje { get; set; }
            public bool Error { get; set; }

            public ConsultaReponseHistorial(List<Historial> historial)
            {
                Historiales = historial;
                Error = false;
            }

            public ConsultaReponseHistorial(string mensaje)
            {
                Mensaje = mensaje;
                Error = true;
            }

        }
    }

}




