using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Lógica;

namespace _Presentación
{
    public partial class Asistencia : Form
    {
        Cliente cliente;
        ClienteService clienteService;
        public Asistencia()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnectionString.Cadena);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ConsultaReponseCliente respuesta ;
       
           respuesta  = clienteService.ConsultarClientes(Convert.ToInt32(txtid.Text));

            AbrirFormHija(new Asistenciapersonal());

           

            DateTime fecha = Convert.ToDateTime(respuesta.Clientes);
            fecha = fecha.AddDays(-1);

        }
        private void AbrirFormHija(object Formhijo)
        {
            if (this.panelInformacion.Controls.Count > 0)
                this.panelInformacion.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelInformacion.Controls.Add(fh);
            this.panelInformacion.Tag = fh;
            fh.Show();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
