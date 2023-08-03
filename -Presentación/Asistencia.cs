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
        //Cliente cliente;
        ClienteService clienteService;
        public Asistencia()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnectionString.Cadena);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BusquedaReponseCliente respuesta ;
            string id = txtid.Text;

            respuesta  = clienteService.BuscarCliente(id);
            //MessageBox.Show(respuesta.Cliente.Nombre);

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                panelInformacion.Visible = true;
                if (respuesta.Cliente.Sexo.Equals("Masculino "))
                {
            
                    logohombre.Visible = true;
                    logomujer.Visible = false;

                    lblnombre.Text = respuesta.Cliente.Nombre + " " + respuesta.Cliente.Apellido;
                    
                }
                else
                {
                    if (respuesta.Cliente.Sexo == "Femenino")
                       
                    logomujer.Visible = true;
                    logohombre.Visible = false;

                    lblnombre.Text = respuesta.Cliente.Nombre +" " + respuesta.Cliente.Apellido;
                    
                }

                DateTime fechaingreso = DateTime.Parse(respuesta.Cliente.FechaIngreso);

                DateTime fechavencimiento = fechaingreso.AddMonths(1);

                DateTime fechaactual = DateTime.Now.Date;

                TimeSpan diferencia = fechavencimiento - fechaactual;

                int diasvencidos = diferencia.Days;

                lblfecha.Text = diasvencidos.ToString()+" DÍAS";
            }

            //AbrirFormHija(new Asistenciapersonal());



            //DateTime fecha = Convert.ToDateTime(respuesta.Cliente);
            //fecha = fecha.AddDays(-1);

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

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void logomujer_Click(object sender, EventArgs e)
        {

        }

        private void Asistencia_Load(object sender, EventArgs e)
        {

        }

        private void logohombre_Click(object sender, EventArgs e)
        {

        }
    }
}
