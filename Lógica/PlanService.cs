using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class PlanService
    {
        PlanRepository planRepository;
        ConnectionManager connectionManager;
        //List<Cliente> clientes;
        public PlanService(string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            planRepository = new PlanRepository(connectionManager.Connetion);

        }

        public string GuardarPlan(Plan plan)
        {
            try
            {
                connectionManager.Open();

                if (planRepository.BuscarPlanPorCodigo(plan.CodigoPlan) == null)
                {
                    planRepository.GuardarPlanRep(plan);
                    return "El nuevo plan ha sido registrado correctamente!";
                }
                else
                {
                    return $"El plan con el código {plan.CodigoPlan}, ya se encuentra registrado";
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

        public string EliminarPlan(string codigo)
        {
            try
            {
                connectionManager.Open();
                if (planRepository.BuscarPlanPorCodigo(codigo) != null)
                {
                    planRepository.EliminarPlanRep(codigo);
                    return $"Se eliminó el plan con el código {codigo}";
                }
                return $"No se encontró el plaan con el código {codigo}";
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

        public string ModificarPlan(Plan planNuevo, string codigo)
        {
            try
            {
                connectionManager.Open();

                if (planRepository.BuscarPlanPorCodigo(codigo) != null)
                {
                    planRepository.ModificarPlan(planNuevo, codigo);
                    return $"Se modificó el plan con el código {codigo}";
                }
                return $"No se encontró el plan con el código {codigo}";
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
        public List<Plan> ConsultarListPlanes()
        {
            List<Plan> planes = new List<Plan>();

            try
            {
                connectionManager.Open();
                planes = planRepository.ConsultarListPlanes();
            }
            catch (Exception exception)
            {

            }
            finally
            {
                connectionManager.Close();
            }
            return planes;
        }
        public ConsultaReponsePlan ConsultarPlanes(string codigo)
        {
            try
            {
                connectionManager.Open();

                return new ConsultaReponsePlan(planRepository.ConsultarPlanes(codigo));
            }
            catch (Exception exception)
            {
                return new ConsultaReponsePlan("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
    }
    public class ConsultaReponsePlan
    {
        public List<Plan> Planes { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaReponsePlan(List<Plan> planes)
        {
            Planes = planes;
            Error = false;
        }

        public ConsultaReponsePlan(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
}
