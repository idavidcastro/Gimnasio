using Entidad;
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

    public partial class Pagos : Form
    {
        string connectionString = " ";
        int clienteId = 123; // El ID del cliente al que se le está registrando el pago
        public Cliente ClienteSeleccionado { get; set; }

        /*     public TextBox Txtnombre { get; set; }
       public TextBox Txtapellido { get; set; }
       public TextBox Txtfecha { get; set; }
        */
        public Pagos()
        {
            InitializeComponent();
        }
        /* public TextBox Txtnombre
          {
             get { return txtnombre; }
             set { txtnombre = value; }
         }
         public TextBox Txtapellido
         {
             get { return txtapellido; }
             set { txtapellido = value; }
         }
         public TextBox Txtfecha
         {
             get { return txtfecha; }
             set { txtfecha = value; }
         }
         public TextBox Txtplan
         {
             get { return txtplan; }
             set { txtplan = value; }
         }*/
        private void Pagos_Load(object sender, EventArgs e)
        {
            if (ClienteSeleccionado != null)
            {
                txtidentificacion.Text = ClienteSeleccionado.Identificacion;
                txtnombre.Text = ClienteSeleccionado.Nombre;
                txtapellido.Text = ClienteSeleccionado.Apellido;

                txtplan.Text = ClienteSeleccionado.PlanCliente.ToString();
                // Asegúrate de convertir la fecha a string si es necesario
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

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

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
           

            string connectionString = "Data Source=DESKTOP-RQHLETS\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                int identificacion = int.Parse(txtidentificacion.Text);
                string nombre = txtnombre.Text;
                string apellido = txtapellido.Text;
                string fecha = lblfecha.Text;
                string plan = txtplan.Text;

                // Inserción en la tabla "historial"
                string insertQuery = "INSERT INTO historial (Identificacion, Nombre, Apellido,Plann,Fecha) VALUES (@Identificacion, @nombre, @apellido,@plann, @fecha)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {

                    // Agregar los parámetros de la inserción
                    insertCommand.Parameters.AddWithValue("@Identificacion", identificacion);
                    insertCommand.Parameters.AddWithValue("@Nombre", nombre);
                    insertCommand.Parameters.AddWithValue("@Apellido", apellido);

                    insertCommand.Parameters.AddWithValue("@Plann", plan);

                    insertCommand.Parameters.AddWithValue("@Fecha", fecha);


                    // Ejecutar la inserción

                    insertCommand.ExecuteNonQuery();

                    if (lblfecha.Text == "")
                        MessageBox.Show("Debe seleccionar una fecha  .....!!!!");
                }
    MessageBox.Show("¡Pago Resgistrado!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            }



        }
    }

            
            /*
                        int identificacion = int.Parse(txtidentificacion.Text);
                        string nombre = txtnombre.Text;
                        string apellido = txtapellido.Text;
                        string fecha = lblfecha.Text;
                        string plan = txtplan.Text;
            */

            /*
             *
                        try
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();

                                string insertQuery = "INSERT INTO Historial (Identificacion, Nombre, Apellido, Fecha, Plann) " +
                                                     "VALUES (@Identificacion, @Nombre, @Apellido, @Fecha, @plann)";

                                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                                {
                                    command.Parameters.AddWithValue("@Identificacion", Identificacion);
                                    command.Parameters.AddWithValue("@Nombre", Nombre);
                                    command.Parameters.AddWithValue("@Apellido", Apellido); // Por ejemplo, se podría registrar el tipo de modificación
                                    command.Parameters.AddWithValue("@Fecha", Fecha); // No aplica en un registro nuevo
                                    command.Parameters.AddWithValue("@Plann", Plann); // Convierte el monto a string con dos decimales

                                    command.ExecuteNonQuery();
                                }
                            }

                            Console.WriteLine("Registro de pago exitoso.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error al registrar el pago: " + ex.Message);
                        }

                        */

        
        /*public Pagos(String nombre, String apellido, String fecha, String plan)
{
txtnombre.Text = nombre;
txtapellido.Text = apellido;
txtfecha.Text = fecha;
txtplan.Text = plan;
}*/
    

