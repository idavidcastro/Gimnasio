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
        Cliente cliente;
        Plan plan;
        ClienteService clienteService;
        List<Cliente> clientes;
        public Registro()
        {
            InitializeComponent();
            MostrarPlanes();
            clienteService = new ClienteService(ConfigConnectionString.Cadena);
            CargarListado();
        }
        public void CargarListado()
        {
            clientes = new List<Cliente>();
            clientes = clienteService.ConsultarListClientes();
            //MessageBox.Show(clientes.ToString());
            dataGridView777.DataSource = clientes;
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
            lblfecha.Text = DateTime.Today.Date.ToString("d");


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
            
            Cliente cliente = new Cliente();
            cliente.Identificacion = int.Parse(txtidentificacion.Text);
            cliente.Nombre = txtnombre.Text;
            cliente.Apellido = txtapellido.Text;
            cliente.Edad = int.Parse(txtedad.Text);
            cliente.Sexo = cmbsexo.Text;
            cliente.Direccion = txtdireccion.Text;
            cliente.PlanCliente = plan;

            cliente.FechaIngreso = lblfecha.Text;
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
            lblfecha.Text = fecha.ToString();
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
    }
}
