using Entidad;
using Lógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Presentación
{

    public partial class Registro : Form
    {
        Historial   historiall;
        Cliente cliente;
        Plan plan;
        ClienteService clienteService;
        List<Cliente> clientes;
   
        HistorialServices historialServices;

      

        public Registro()
        {
            InitializeComponent();
            MostrarPlanes();
            clienteService = new ClienteService(ConfigConnectionString.Cadena);
            CargarListado();
            txtnombre.Focus();

        }
        private void CargarListado()
        {

            clientes = new List<Cliente>();
            clientes = clienteService.ConsultarListClientes();
            
            dataRegistro.DataSource = clientes;

            //dataRegistro.CurrentRow.Cells[8].Value.ToString();

        }
        
        private void LimpiarCampos()
        {
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtidentificacion.Text = "";
            txtedad.Text = "";
            txttelefono.Text = "";
            cmbsexo.Text = "";
            txtdireccion.Text = "";
            cmbplan.Text = "";
            lblfecha.Text = "";
        }
        
        private void MostrarPlanes()
        {
            SqlConnection cn = new SqlConnection(ConfigConnectionString.Cadena);
            SqlCommand cm = new SqlCommand("select *from Plann", cn);
            cn.Open();
            SqlDataReader reader = cm.ExecuteReader()
;
            while (reader.Read())
            {
                cmbplan.Items.Add(reader.GetString(1));
            }
            cn.Close();
        }
        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lblfecha.Text = DateTime.Now.ToShortDateString();


            if (txtnombre.Text == "")
                MessageBox.Show("Debe seleccionar un Nombre .....!!!!");
            else if (txtapellido.Text == "")
                MessageBox.Show("Debe ingresar un Apellido ...!!!!");
            else if (txtidentificacion.Text == "")
                MessageBox.Show("Debe ingresar una identificacion ...!!!!");
            else if (cmbsexo.SelectedIndex == -1)
                MessageBox.Show("Debe ingresar un Sexo ...!!!!");
            else if (txttelefono.Text == "")
                MessageBox.Show("Debe ingresar un Telefono ...!!!!");
            else if (txtedad.Text == "")
                MessageBox.Show("Debe ingresar Edad ...!!!!");
            else if (txtdireccion.Text == "")
                MessageBox.Show("Debe ingresar un Barrio...!!!!");
            else if (cmbplan.Text == "")
                MessageBox.Show("Debe ingresar un Plan  ...!!!!");
            /*
            else
            {
                //capturando datos//
                string Nombre = txtnombre.Text;
                string Apellido = txtapellido.Text;
                string identificacion = txtidentificacion.Text;
                string sexo = cmbsexo.Text;
                string telefono = txttelefono.Text;
                string edad = txtedad.Text;
                string barrio = txtdireccion.Text;
                string plan = cmbplan.Text;


                dataRegistro.Rows.Add();

                int cantfilas = dataRegistro.Rows.Count - 1;

                dataRegistro[0, cantfilas].Value = txtnombre.Text;
                dataRegistro[1, cantfilas].Value = txtapellido.Text;
                dataRegistro[2, cantfilas].Value = txtidentificacion.Text;
                dataRegistro[3, cantfilas].Value = cmbsexo.Text;
                dataRegistro[4, cantfilas].Value = txttelefono.Text;
                dataRegistro[5, cantfilas].Value = txtedad.Text;
                dataRegistro[6, cantfilas].Value = txtdireccion.Text;
                dataRegistro[7, cantfilas].Value = cmbplan.Text;
                dataRegistro[8, cantfilas].Value = lblfecha.Text;

                txtnombre.Text = "";
              txtapellido.Text = "";
                 txtidentificacion.Text = "";
               cmbsexo.Text = "";
                txttelefono.Text = "";
                 txtedad.Text = "";
               txtdireccion.Text = "";
               cmbplan.Text = "";
            }
            */

            plan = new Plan()
            {
                CodigoPlan=txtcodigoplan.Text,
                NombrePlan=txtnombreplan.Text,
                ValorPlan=decimal.Parse(txtvalorplan.Text)
            };
            
            cliente = new Cliente();
            cliente.Identificacion = txtidentificacion.Text;
            cliente.Nombre = txtnombre.Text;
            cliente.Apellido = txtapellido.Text;
            cliente.Edad = txtedad.Text;
            cliente.Telefono = txttelefono.Text;
            cliente.Sexo = cmbsexo.Text;
            cliente.Direccion = txtdireccion.Text;
            cliente.PlanCliente = plan;

            cliente.FechaIngreso = lblfecha.Text;
            cliente.Estado = "Activo";


   historiall = new Historial();
            historiall.Identificacion = txtidentificacion.Text;
           historiall.Nombre = txtnombre.Text;
            historiall.Apellido = txtapellido.Text;
          historiall.PlanCliente = plan;

           historiall.FechaIngreso = lblfecha.Text;


            /*
            cliente = new Cliente
            {
                Identificacion = int.Parse(txtidentificacion.Text),
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Edad = int.Parse(txtedad.Text),
                Sexo = cmbsexo.Text,
                Direccion = txtdireccion.Text,
                PlanCliente = plan,
                
                FechaIngreso = dateTimePicker1.Text
            };
            */
            string mensaje = clienteService.GuardarCliente(cliente);
            MessageBox.Show(mensaje, "Guardar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarListado();
            LimpiarCampos();
     
     

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if
           (calendario.Visible == true)
            {
                calendario.Visible = false;
            }
            else
                calendario.Visible = true;



            DateTime fecha = calendario.SelectionStart;
            lblfecha.Text = fecha.ToShortDateString();

            DateTime fechavencimiento = fecha.AddMonths(1);
            MessageBox.Show(fechavencimiento.ToShortDateString());
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbplan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigConnectionString.Cadena);
            cn.Open();
            SqlCommand cmm = new SqlCommand("select * from Plann where Nombre= '" + cmbplan.Text + "'", cn);
            SqlDataReader readerr = cmm.ExecuteReader();
            if (readerr.Read() == true)
            {
                txtcodigoplan.Text = readerr["CodigoPlan"].ToString();
                txtnombreplan.Text = readerr["Nombre"].ToString();
                txtvalorplan.Text = readerr["Valor"].ToString();

            }
            cn.Close();
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dataRegistro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnombre.Text = dataRegistro.CurrentRow.Cells[0].Value.ToString();
            txtapellido.Text = dataRegistro.CurrentRow.Cells[1].Value.ToString();
            txtidentificacion.Text = dataRegistro.CurrentRow.Cells[2].Value.ToString();
            txtedad.Text = dataRegistro.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text= dataRegistro.CurrentRow.Cells[4].Value.ToString();
            cmbsexo.Text = dataRegistro.CurrentRow.Cells[5].Value.ToString();
            txtdireccion.Text = dataRegistro.CurrentRow.Cells[6].Value.ToString();
            cmbplan.Text = dataRegistro.CurrentRow.Cells[7].Value.ToString();
            lblfecha.Text = dataRegistro.CurrentRow.Cells[8].Value.ToString();
            labelEstado.Text= dataRegistro.CurrentRow.Cells[9].Value.ToString();

            SqlConnection cn = new SqlConnection(ConfigConnectionString.Cadena);
            cn.Open();

            SqlCommand cm = new SqlCommand("select * from Plann where Nombre= '" + cmbplan.Text + "'", cn);
            SqlDataReader reader = cm.ExecuteReader();
            if (reader.Read() == true)
            {
                txtcodigoplanotro.Text = reader["CodigoPlan"].ToString();
                txtnombreplanotro.Text = reader["Nombre"].ToString();
                txtvalorplanotro.Text = reader["Valor"].ToString();              

            }
            cn.Close();
        }

        private void lblfecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            plan = new Plan()
            {
                CodigoPlan = txtcodigoplanotro.Text,
                NombrePlan = txtnombreplanotro.Text,
                ValorPlan = decimal.Parse(txtvalorplanotro.Text)
            };

            cliente = new Cliente();
            cliente.Identificacion = txtidentificacion.Text;
            cliente.Nombre = txtnombre.Text;
            cliente.Apellido = txtapellido.Text;
            cliente.Edad = txtedad.Text;
            cliente.Telefono = txttelefono.Text;
            cliente.Sexo = cmbsexo.Text;
            cliente.Direccion = txtdireccion.Text;
            cliente.PlanCliente = plan;
            cliente.FechaIngreso = lblfecha.Text;
            cliente.Estado = labelEstado.Text;
            

            string mensaje = clienteService.ModificarCliente(cliente, txtidentificacion.Text);
            MessageBox.Show(mensaje, "Modificar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarListado();
            
        }

        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dataRegistro.CurrentRow.Cells[2].Value);

            string mensaje = clienteService.EliminarCliente(id);
            MessageBox.Show(mensaje, "Eliminar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CargarListado();
            LimpiarCampos();
        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }
    }
}
