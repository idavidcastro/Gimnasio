using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ClienteService
    {
        ClienteRepository clienteRepository;
        ConnectionManager connectionManager;
        //List<Cliente> clientes;
        public ClienteService(string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            clienteRepository = new ClienteRepository(connectionManager.Connetion);

        }

        public string GuardarCliente(Cliente cliente)
        {
            try
            {
                connectionManager.Open();

                if (clienteRepository.BuscarClientePorIdentificacion(cliente.Identificacion) == null)
                {
                    clienteRepository.GuardarClienteRep(cliente);
                    return "El nuevo cliente ha sido registrado correctamente!";
                }
                else
                {
                    return $"El cliente con la identificacion {cliente.Identificacion}, ya se encuentra registrado";
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

        public string EliminarCliente(int identificacion)
        {
            try
            {
                connectionManager.Open();
                if (clienteRepository.BuscarClientePorIdentificacion(identificacion) != null)
                {
                    clienteRepository.EliminarClienteRep(identificacion);
                    return $"Se eliminó el cliente con la identificacion {identificacion}";
                }
                return $"No se encontró el cliente con identificacion {identificacion}";
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error: " + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ModificarCliente(Cliente clienteNuevo, int identificacion)
        {
            try
            {
                connectionManager.Open();

                if (clienteRepository.BuscarClientePorIdentificacion(identificacion) != null)
                {
                    clienteRepository.ModificarCliente(clienteNuevo, identificacion);
                    return $"Se modificó el cliente con la identificacion {identificacion}";
                }
                return $"No se encontró el cliente con identificacion {identificacion}";
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error: " + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public List<Cliente> ConsultarListClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                connectionManager.Open();
                clientes = clienteRepository.ConsultarListClientes();
            }
            catch (Exception exception)
            {
                
            }
            finally
            {
                connectionManager.Close();
            }
            return clientes;
        }
        public ConsultaReponseCliente ConsultarClientes(string identificacion)
        {
            try
            {
                connectionManager.Open();

                return new ConsultaReponseCliente(clienteRepository.ConsultarClientes(identificacion));
            }
            catch (Exception exception)
            {
                return new ConsultaReponseCliente("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public BusquedaReponseCliente BuscarCliente(int id)
        {
            try
            {
                connectionManager.Open();
                if (clienteRepository.BuscarClientePorIdentificacion(id) == null)
                {
                    return new BusquedaReponseCliente($"El cliente con la identificación {id} NO se encuentra registrado");

                }
                else
                {
                    return new BusquedaReponseCliente(clienteRepository.BuscarClientePorIdentificacion(id));
                }
            }
            catch (Exception exception)
            {

                return new BusquedaReponseCliente("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }

        }
    }
    public class ConsultaReponseCliente
    {
        public List<Cliente> Clientes { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaReponseCliente(List<Cliente> clientes)
        {
            Clientes = clientes;
            Error = false;
        }

        public ConsultaReponseCliente(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
    public class BusquedaReponseCliente
    {
        public Cliente Cliente { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public BusquedaReponseCliente(Cliente cliente)
        {
            Cliente = cliente;
            Error = false;
        }

        public BusquedaReponseCliente(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
}
