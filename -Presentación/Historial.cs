using Entidad;
using Lógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _Presentación
{
    public partial class Historial : Form
    {
        public Cliente ClienteSeleccionado { get; set; }
        string connectionString = "Data Source=DESKTOP-RQHLETS\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=true";
        private Cliente cliente;
        private string documentoSeleccionado;


        public Historial(string documentoSeleccionado)
        {
            this.identificacionCliente = identificacionCliente;
            InitializeComponent();
            documentoSeleccionado = documento;
        }
       
        public Historial(Cliente clienteSeleccionado)
        {
            this.clienteSeleccionado = clienteSeleccionado;
    
        }

        public Historial()
        {
            InitializeComponent();
        }

        private string identificacionCliente;
        private Cliente clienteSeleccionado;
        private string documento;
     

        // Constructor para recibir la identificación del cliente

        private void Historial_Load(object sender, EventArgs e)
        {


            if (ClienteSeleccionado != null)
            {
                dataHistorial.Rows.Clear();

                // Añadir una nueva fila al DataGridView con los datos del cliente seleccionado
                dataHistorial.Rows.Add(ClienteSeleccionado.Identificacion, ClienteSeleccionado.Nombre, ClienteSeleccionado.Apellido, ClienteSeleccionado.PlanCliente.ToString());
            }
            /* /* CargarDatos();*/
            // Utilizar el valor de la identificación para realizar la consulta en la carga del formulario
            /*  string connectionString = "Data Source=DESKTOP-RQHLETS\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=true"; // Reemplaza esto con la cadena de conexión a tu base de datos
              string selectQuery = "SELECT Identificacion, Nombre, Apellido, Plann, Fecha FROM Historial WHERE Identificacion = @identificacionCliente";

              try
              {
                  using (SqlConnection connection = new SqlConnection(connectionString))
                  {
                      connection.Open();

                      using (SqlCommand command = new SqlCommand(selectQuery, connection))
                      {
                          command.Parameters.AddWithValue("@identificacionCliente", identificacionCliente);

                          // Aquí puedes ejecutar el comando y leer los datos del historial del cliente
                          // (por ejemplo, mediante un SqlDataReader o cargando los datos en un DataTable).
                      }
                  }
              }
              catch (Exception ex)
              {
                  Console.WriteLine("Error al consultar el historial del cliente: " + ex.Message);
              }*/
        }

        


        private void dataHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


