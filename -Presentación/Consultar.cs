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
    public partial class Consultar : Form
    {
        ClienteService clienteService;
        List<Cliente> clientes;
        public Consultar()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnectionString.Cadena);
            CargarListado();

        }
        public void CargarListado()
        {
            clientes = new List<Cliente>();
            clientes = clienteService.ConsultarListClientes();

            dataConsulta.DataSource = clientes;
        }
        private void Consultar_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7777_Click(object sender, EventArgs e)
        {
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
            txtidConsulta.Text = "";
        }

        private void dataConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
