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
                command.CommandText = "insert into Cliente(Identificacion,Nombre,Apellido,Edad,Sexo,Direccion,CodPlan,Plann,ValorPlan,Fecha)" +
                              " values (@Identificacion, @Nombre, @Apellido, @Edad, @Sexo, @Direccion, @CodPlan,@Plann,@ValorPlan, @Fecha)";
                command.Parameters.Add(new SqlParameter("@Identificacion", cliente.Identificacion));
                command.Parameters.Add(new SqlParameter("@Nombre", cliente.Nombre));
                command.Parameters.Add(new SqlParameter("@Apellido", cliente.Apellido));
                command.Parameters.Add(new SqlParameter("@Edad", cliente.Edad));
                command.Parameters.Add(new SqlParameter("@Sexo", cliente.Sexo));
                command.Parameters.Add(new SqlParameter("@Direccion", cliente.Direccion));
                command.Parameters.Add(new SqlParameter("@CodPlan", cliente.PlanCliente.CodigoPlan));
                command.Parameters.Add(new SqlParameter("@Plann", cliente.PlanCliente.NombrePlan));
                command.Parameters.Add(new SqlParameter("@ValorPlan", cliente.PlanCliente.ValorPlan));
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
                        Cliente cliente = new Cliente
                        {
                            Identificacion = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            Edad = reader.GetInt32(3),
                            Sexo = reader.GetString(4),
                            Direccion = reader.GetString(5),
                            PlanCliente = new Plan
                            {
                                CodigoPlan = reader.GetString(6),
                                NombrePlan = reader.GetString(7),
                                ValorPlan = reader.GetDecimal(8)
                            },
                            FechaIngreso = reader.GetDateTime(9)
                        };

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

        public void ModificarCliente(Cliente clienteNuevo, int identificacion)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update Cliente set Identificacion=@Identificacion,Nombre=@Nombre,Apellido=@Apellido,Edad=@Edad," +
                    "Sexo=@Sexo, Direccion=@Direccion,CodPlan=@CodPlan,Plann=@Plann,ValorPlan=@ValorPlan,Fecha=@Fecha" +
                    " where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", identificacion));
                command.Parameters.Add(new SqlParameter("@Nombre", clienteNuevo.Nombre));
                command.Parameters.Add(new SqlParameter("@Apellido", clienteNuevo.Apellido));
                command.Parameters.Add(new SqlParameter("@Edad", clienteNuevo.Edad));
                command.Parameters.Add(new SqlParameter("@Sexo", clienteNuevo.Sexo));
                command.Parameters.Add(new SqlParameter("@Direccion", clienteNuevo.Direccion));
                command.Parameters.Add(new SqlParameter("@CodPlan", clienteNuevo.PlanCliente.CodigoPlan));
                command.Parameters.Add(new SqlParameter("@Plann", clienteNuevo.PlanCliente.NombrePlan));
                command.Parameters.Add(new SqlParameter("@ValorPlan", clienteNuevo.PlanCliente.ValorPlan));
                command.Parameters.Add(new SqlParameter("@Fecha", clienteNuevo.FechaIngreso));

                command.ExecuteNonQuery();
            }
        }

        public List<Cliente> ConsultarClientes(int identificacion)
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Cliente where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", identificacion));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        Identificacion = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Edad = reader.GetInt32(3),
                        Sexo = reader.GetString(4),
                        Direccion = reader.GetString(5),
                        PlanCliente = new Plan
                        {
                            CodigoPlan = reader.GetString(6),
                            NombrePlan = reader.GetString(7),
                            ValorPlan = reader.GetDecimal(8)
                        },
                        FechaIngreso = reader.GetDateTime(9)
                    };

                    clientes.Add(cliente);
                }
                reader.Close();
            }

            return clientes;
        }
        public List<Cliente> ConsultarListClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Cliente";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        Identificacion = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        Edad = reader.GetInt32(3),
                        Sexo = reader.GetString(4),
                        Direccion = reader.GetString(5),
                        PlanCliente = new Plan
                        {
                            CodigoPlan = reader.GetString(6),
                            NombrePlan = reader.GetString(7),
                            ValorPlan = reader.GetDecimal(8)
                        },
                        FechaIngreso = reader.GetDateTime(9)
                    };

                    clientes.Add(cliente);
                }
                reader.Close();
            }

            return clientes;
        }
    }
}
