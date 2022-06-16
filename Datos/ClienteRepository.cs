using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ClienteRepository
    {
        DbConnection _connection;
        private List<Cliente> clientes;
        public ClienteRepository(DbConnection connection)
        {
            _connection = connection;
            clientes = new List<Cliente>();
        }

        public void GuardarClienteRep(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Cliente(Identificacion,Nombre,Apellido,Edad,Sexo,Direccion,Plann,Fecha)" +
                              " values (@Identificacion, @Nombre, @Apellido, @Edad, @Sexo, @Direccion, @Plann, @Fecha)";
                command.Parameters.Add(new SqlParameter("@Identificacion", cliente.Identificacion));
                command.Parameters.Add(new SqlParameter("@Nombre", cliente.Nombre));
                command.Parameters.Add(new SqlParameter("@Apellido", cliente.Apellido));
                command.Parameters.Add(new SqlParameter("@Edad", cliente.Edad));
                command.Parameters.Add(new SqlParameter("@Sexo", cliente.Sexo));
                command.Parameters.Add(new SqlParameter("@Direccion", cliente.Direccion));
                command.Parameters.Add(new SqlParameter("@Plann", cliente.PlanCliente));
                command.Parameters.Add(new SqlParameter("@Fecha", cliente.FechaIngreso));

                command.ExecuteNonQuery();
            }
        }

        public Cliente BuscarClientePorIdentificacion(int identificacion)
        {
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "select *from Cliente where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", identificacion));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Identificacion = reader.GetInt32(0);
                        cliente.Nombre = reader.GetString(1);
                        cliente.Apellido = reader.GetString(2);
                        cliente.Edad = reader.GetInt32(3);
                        cliente.Sexo = reader.GetString(4);
                        cliente.Direccion = reader.GetString(5);
                        cliente.PlanCliente = new Plan();
                        cliente.PlanCliente.NombrePlan = reader.GetString(6);
                        cliente.FechaIngreso = reader.GetDateTime(7);                      

                        return cliente;
                    }
                }
                reader.Close();
            }
            return null;
        }


        public void EliminarClienteRep(int identificacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "delete From Cliente where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", identificacion));
                command.ExecuteNonQuery();
            }
        }

        public void ModificarDocente(Cliente clienteNuevo, int identificacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update Cliente set Identificacion=@Identificacion,Nombre=@Nombre,Apellido=@Apellido,Edad=@Edad," +
                    "Sexo=@Sexo, Direccion=@Direccion,Plann=@Plann, Fecha=@Fecha" +
                    " where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", identificacion));
                command.Parameters.Add(new SqlParameter("@Nombre", clienteNuevo.Nombre));
                command.Parameters.Add(new SqlParameter("@Apellido", clienteNuevo.Apellido));
                command.Parameters.Add(new SqlParameter("@Edad", clienteNuevo.Edad));
                command.Parameters.Add(new SqlParameter("@Sexo", clienteNuevo.Sexo));
                command.Parameters.Add(new SqlParameter("@Direccion", clienteNuevo.Direccion));
                command.Parameters.Add(new SqlParameter("@Plann", clienteNuevo.PlanCliente.NombrePlan));
                command.Parameters.Add(new SqlParameter("@Fecha", clienteNuevo.FechaIngreso));

                command.ExecuteNonQuery();
            }
        }
    }
}
