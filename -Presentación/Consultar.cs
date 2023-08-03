using Datos;
using Entidad;
using Lógica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using static Lógica.HistorialServices;

namespace _Presentación
{
    public partial class Consultar : Form
    {
        ClienteService clienteService;
        List<Cliente> clientes;
        HistorialServices historialservices;
      

        ConnectionManager connectionManager; // Asegúrate de que se haya declarado e inicializado este objeto

        private string connectionString = "Data Source=DESKTOP-RQHLETS?\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=true"; // Reemplaza esto con la cadena de conexión a tu base de datos
        private Cliente clienteSeleccionado;


        private void AbrirFormHijo(object Formhijo)
        {

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;

            fh.Show();
        }
        public Consultar()
        {
            InitializeComponent();
       

           
            historialservices = new HistorialServices(ConfigConnectionString.Cadena);
            clienteService = new ClienteService(ConfigConnectionString.Cadena);
            CargarListado();
            connectionManager = new ConnectionManager(connectionString);


        }

     

        public void CargarListado()
        {
            clientes = new List<Cliente>();
            clientes = clienteService.ConsultarListClientes();

            dataConsulta.DataSource = clientes;
        }
        private void Consultar_Load(object sender, EventArgs e)
        {
            txtidConsulta.TextChanged += TxtidConsulta_TextChanged;
        }

        private void TxtidConsulta_TextChanged(object sender, EventArgs e)
        {
            string identificacionCliente = txtidConsulta.Text;
          
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7777_Click(object sender, EventArgs e)
        {


            // Cargar el historial del cliente ingresado en el DataGridView

             // Valor ingresado en la caja de texto de identificación del cliente


            ConsultaReponseCliente respuesta;

            respuesta = clienteService.ConsultarClientes(txtidConsulta.Text);

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                dataConsulta.DataSource = respuesta.Clientes;
            }
         
        }

        private void dataConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e, Historial bTNHISTORIAL)
        {
            /*
            Historial BTNHISTORIAL = new Historial();
            BTNHISTORIAL.Show();
               DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
               btn.HeaderText = "HISTORIAL";
               btn.Name = "button";
               btn.Text = "Ver Historial";
                   btn.UseColumnTextForButtonValue = true;*/






        }

        private void Historial(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Historial(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataConsulta_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaReponseHistorial respuesta;
            Historial historial = new Historial();

            respuesta = historialservices.ConsultarHistorial(txtidConsulta.Text);

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                historial.dataHistorial.DataSource = respuesta.Historiales;
            }
       

            

              historial.Show();

            /*  if (clienteSeleccionado != null)
              {

                  // Crea una instancia del formulario "Pagos"
                  Historial historial = new Historial();
                  historial.ClienteSeleccionado = clienteSeleccionado;

                  // Muestra el formulario "Pagos"
                  historial.Show();
              }
              else
              {
                  MessageBox.Show("Por favor, seleccione un cliente en el DataGridView antes de presionar el botón.");
              }

  */
            // Cargar el historial del cliente ingresado en el DataGridView





            /*  string selectQuery = "SELECT Identificacion, Nombre, Apellido, Plann, Fecha FROM Historial WHERE Identificacion = @Identificacion";

              try
              {
                  using (SqlConnection connection = new SqlConnection(connectionString))
                  {
                      connection.Open();

                      using (SqlCommand command = new SqlCommand(selectQuery, connection))
                      {
                          // Agregar el parámetro para filtrar por la identificación del cliente
                          command.Parameters.AddWithValue("@Identificacion", identificacionCliente);

                          // Utilizar un SqlDataAdapter para llenar el DataTable con los resultados de la consulta
                          using (SqlDataReader reader = command.ExecuteReader())
                          {
                              if (reader.HasRows)
                              {
                                  // Limpiar el DataGridView antes de llenarlo con los nuevos datos
                                  dataConsulta.Rows.Clear();

                                  while (reader.Read())
                                  {
                                      // Leer los valores de las columnas y agregarlos como una nueva fila en el DataGridView
                                      string identificacion = reader["Identificacion"].ToString();
                                      string nombre = reader["Nombre"].ToString();
                                      string apellido = reader["Apellido"].ToString();
                                      string plann = reader["Plann"].ToString();
                                      string fecha = reader["Fecha"].ToString();

                                      dataConsulta.Rows.Add(identificacionCliente, nombre, apellido, plann, fecha);
                                  }
                              }
                              else
                              {
                                  // Si no se encontró el cliente, mostrar un mensaje
                                  MessageBox.Show("Cliente no encontrado.");
                              }
                          }
                      }
                  }


              }
              // Asignar el DataTable como origen de datos del DataGridView


              catch (Exception ex)
              {
                  Console.WriteLine("Error al cargar el historial: " + ex.Message);
              }*/

        }

       

        // Resto del código del formulario...



        private void button3_Click(object sender, EventArgs e)
        {

            Form formulario = new Pagos();
            formulario.Show();

            /*
            if (dataConsulta.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataConsulta.SelectedRows[0];
                string Nombre = selectedRow.Cells["Nombre"].Value.ToString();
                string Apellido = selectedRow.Cells["Apellido"].Value.ToString();
                string Fecha = selectedRow.Cells["FechaIngreso"].Value.ToString();
                string plan1 = selectedRow.Cells["PlanCliente"].Value.ToString();


                // Instanciar el Formulario B y pasar los datos mediante el constructor personalizado
                Pagos pagos = new Pagos(Nombre, Apellido, Fecha,plan1);
               pagos.ShowDialog();



            } */

        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(dataConsulta.AccessibilityObject.ToString(), out int idClienteSeleccionado))
            {

            }
        }


       

        private void dataConsulta_SelectionChanged(object sender, EventArgs e)
        {




        }

        private void dataConsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < clientes.Count)
            {


                // Obtén los datos del cliente seleccionado desde el DataGridView

                Cliente clienteSeleccionado = clientes[e.RowIndex];

                // Crea una instancia del formulario "Form2"
                Pagos pagos = new Pagos();
                pagos.ClienteSeleccionado = clienteSeleccionado;
                // Asigna el dato del cliente a la caja de texto en "Form2"
                /*  pagos.Txtnombre.Text = clienteSeleccionado.Nombre;
                  pagos.Txtapellido.Text = clienteSeleccionado.Apellido;
                  pagos.Txtfecha.Text = clienteSeleccionado.FechaIngreso;*/

                // ... y así sucesivamente para otros datos que desees mostrar en "Form2"

                // Muestra el formulario "Form2"
                pagos.Show();
            }

        }
    }
}




