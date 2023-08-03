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
   public class HistorialRepository
    {
        DbConnection _connection;
        private List<Historial> Historiales;
        public HistorialRepository(DbConnection connection)
        {
            _connection = connection;
            Historiales = new List<Historial>();
        }
        public void GuardarHistorialRep(Historial historial)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Historial(Identificacion,Nombre,Apellido,CodPlan,Plann,ValorPlan,Fecha)" +
                              " values (@Identificacion, @Nombre, @Apellido,@CodPlan,@Plann,@ValorPlan, @Fecha)";
                command.Parameters.Add(new SqlParameter("@Identificacion", historial.Cliente.Identificacion));
                command.Parameters.Add(new SqlParameter("@Nombre", historial.Cliente.Nombre));
                command.Parameters.Add(new SqlParameter("@Apellido",historial.Cliente.Apellido));
                command.Parameters.Add(new SqlParameter("@Plann", historial.PlanCliente.NombrePlan));
       
                command.Parameters.Add(new SqlParameter("@Fecha", historial.Cliente.FechaIngreso));
              
                command.ExecuteNonQuery();

            }
            
        }
        public Historial BuscarHistorialPorIdentificacion(string identificacion)
        {
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "select *from Historial where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", identificacion));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       Historial historial  = new Historial
                        {
                            Cliente = new Cliente
                            {
                                Identificacion = reader.GetString(0),
                                Nombre=reader.GetString(1),
                                Apellido=reader.GetString(2),
                                FechaIngreso=reader.GetString(6)                     
                            },
                           
                           
                            PlanCliente = new Plan
                            {

                                NombrePlan = reader.GetString(4),
                            
                            },    
                        };

                        return historial;
                    }
                }
                reader.Close();
            }
            return null;
        }
        
        public List<Historial> ConsultarHistorial(string identificacion)
        {
            List<Historial> historiales = new List<Historial>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Cliente where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", identificacion));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Historial historial = new Historial
                    {
                       
                        
                        PlanCliente = new Plan
                        {
                          
                            NombrePlan = reader.GetString(3),
                         
                        },
                        Cliente= new Cliente
                        {
                            Identificacion= reader.GetString(0),    
                            Nombre= reader.GetString(1),    
                            Apellido = reader.GetString(2), 
                        },
                        FechaNuevoPago = reader.GetString(5),
                       
                    };

                    historiales.Add(historial);
                }
                reader.Close();
            }

            return historiales;
        }
        



    }
}

    

