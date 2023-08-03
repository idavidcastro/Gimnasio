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
                command.CommandText = "insert into Historial(Identificacion,Nombre,Apellido,Plann,ValorPlan ,Fecha)" +
                              " values (@Identificacion, @Nombre, @Apellido,@Plann,@ValorPlan,  @Fecha)";
                command.Parameters.Add(new SqlParameter("@Identificacion", historial.Identificacion));
                command.Parameters.Add(new SqlParameter("@Nombre", historial.Nombre));
                command.Parameters.Add(new SqlParameter("@Apellido",historial.Apellido));
                command.Parameters.Add(new SqlParameter("@Plann", historial.Plann));
       
                command.Parameters.Add(new SqlParameter("@Fecha", historial.FechaNuevoPago));
              
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

                           Identificacion = reader.GetString(0),
                           Nombre = reader.GetString(1),
                           Apellido = reader.GetString(2),
                           Plann = reader.GetString(3),
                           ValorPlan = reader.GetString(4),

                           FechaNuevoPago = reader.GetString(4),




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
                command.CommandText = "select * from Historial where Identificacion=@Identificacion";
                command.Parameters.Add(new SqlParameter("@Identificacion", identificacion));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Historial historial = new Historial
                    {
                       
                        
                     
                            Identificacion= reader.GetString(0),    
                            Nombre= reader.GetString(1),    
                            Apellido = reader.GetString(2),
                            Plann = reader.GetString(3),
                      ValorPlan = reader.GetString(4),

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

    

