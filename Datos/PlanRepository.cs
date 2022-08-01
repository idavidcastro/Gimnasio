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
    public class PlanRepository
    {
        DbConnection _connection;
        private List<Plan> planes;
        public PlanRepository(DbConnection connection)
        {
            _connection = connection;
            planes = new List<Plan>();
        }

        public void GuardarPlanRep(Plan plan)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Plann(CodigoPlan,Nombre,Valor)" +
                              " values (@CodigoPlan, @Nombre, @Valor)";
                command.Parameters.Add(new SqlParameter("@CodigoPlan", plan.CodigoPlan));
                command.Parameters.Add(new SqlParameter("@Nombre", plan.NombrePlan));
                command.Parameters.Add(new SqlParameter("@Valor", plan.ValorPlan));          

                command.ExecuteNonQuery();
            }
        }

        public Plan BuscarPlanPorCodigo(string codigo)
        {
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "select *from Plann where CodigoPlan=@CodigoPlan";
                command.Parameters.Add(new SqlParameter("@CodigoPlan", codigo));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Plan plan = new Plan();
                        plan.CodigoPlan = reader.GetString(0);
                        plan.NombrePlan = reader.GetString(1);
                        plan.ValorPlan = decimal.Parse(reader.GetString(2));

                        return plan;
                    }
                }
                reader.Close();
            }
            return null;
        }


        public void EliminarPlanRep(string codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "delete From Plann where CodigoPlan=@CodigoPlan";
                command.Parameters.Add(new SqlParameter("@CodigoPlan", codigo));
                command.ExecuteNonQuery();
            }
        }

        public void ModificarPlan(Plan planNuevo, string codigo)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update Plann set CodigoPlan=@CodigoPlan,Nombre=@Nombre,Valor=@Valor" +
                                     " where CodigoPlan=@CodigoPlan";
                command.Parameters.Add(new SqlParameter("@CodigoPlan", codigo));
                command.Parameters.Add(new SqlParameter("@Nombre", planNuevo.NombrePlan));
                command.Parameters.Add(new SqlParameter("@Valor", planNuevo.ValorPlan));

                command.ExecuteNonQuery();
            }
        }
        public List<Plan> ConsultarPlanes(string codigo)
        {
            List<Plan> planes = new List<Plan>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Plann where CodigoPlan=@CodigoPlan";
                command.Parameters.Add(new SqlParameter("@CodigoPlan", codigo));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Plan plan = new Plan
                    {
                        CodigoPlan = reader.GetString(0),
                        NombrePlan = reader.GetString(1),
                        ValorPlan = reader.GetDecimal(2),
                    };

                    planes.Add(plan);
                }
                reader.Close();
            }

            return planes;
        }
        public List<Plan> ConsultarListPlanes()
        {
            List<Plan> planes = new List<Plan>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Plann";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Plan plan = new Plan();
                        plan.CodigoPlan = reader.GetString(0);
                        plan.NombrePlan = reader.GetString(1);
                        plan.ValorPlan = decimal.Parse(reader.GetString(2));
                        
                        planes.Add(plan);
                    }
                }
            }
            return planes;
        }
    }
}
