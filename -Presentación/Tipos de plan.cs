using Entidad;
using Lógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Presentación
{
    public partial class Tipos_de_plancs : Form
    {
        Plan plan;
        PlanService planService;
        List<Plan> planes;
        public Tipos_de_plancs()
        {
            InitializeComponent();
            planService = new PlanService(ConfigConnectionString.Cadena);
            CargarListado();
        }
        public void CargarListado()
        {
            planes = new List<Plan>();
            planes = planService.ConsultarListPlanes();

            dataPanes.DataSource = planes;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
                MessageBox.Show("Debe ingresar un Nombre .....!!!!");
            else if (txtplan.Text == "")
                MessageBox.Show("Debe ingresar un plan ...!!!!");
            else if (txtvalor.Text == "")
                MessageBox.Show("Debe ingresar un valor ...!!!!");
            /*
            else
            
            {
                //capturando datos//
                string codigo = txtcodigo.Text;
                string plan = txtplan.Text;
                string valor = txtvalor.Text;


                dataGridView1.Rows.Add();
                int cantfilas = dataGridView1.Rows.Count - 1;
                dataGridView1[0, cantfilas].Value = txtcodigo.Text;
                dataGridView1[1, cantfilas].Value = txtplan.Text;
                dataGridView1[2, cantfilas].Value = txtvalor.Text;

            }
            */
            plan = new Plan();
            plan.CodigoPlan = txtcodigo.Text;
            plan.NombrePlan = txtplan.Text;
            plan.ValorPlan = decimal.Parse(txtvalor.Text);

            string mensaje = planService.GuardarPlan(plan);
            MessageBox.Show(mensaje, "Guardar plan", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarListado();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tipos_de_plancs_Load(object sender, EventArgs e)
        {

        }

        private void dataPanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = dataPanes.CurrentRow.Cells[0].Value.ToString();
            txtplan.Text = dataPanes.CurrentRow.Cells[1].Value.ToString();
            txtvalor.Text = dataPanes.CurrentRow.Cells[2].Value.ToString();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            plan = new Plan();
            plan.CodigoPlan = txtcodigo.Text;
            plan.NombrePlan = txtplan.Text;
            plan.ValorPlan = decimal.Parse(txtvalor.Text);

            string mensaje = planService.ModificarPlan(plan, txtcodigo.Text);
            MessageBox.Show(mensaje, "Modificar plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarListado();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dataPanes.CurrentRow.Cells[0].Value);
            
            string mensaje = planService.EliminarPlan(id);
            MessageBox.Show(mensaje, "Eliminar estibado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarListado();
        }
    }
}
