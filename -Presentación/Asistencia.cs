﻿using System;
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
            BusquedaReponseCliente respuesta ;
            int id = Convert.ToInt32(txtid.Text);

            respuesta  = clienteService.BuscarCliente(id);
            //MessageBox.Show(respuesta.Cliente.Nombre);

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                panelInformacion.Visible = true;
                if (respuesta.Cliente.Sexo == "Masculino")
                {
                    logomujer.Visible = false;
                    logohombre.Visible = true;
                    MessageBox.Show(respuesta.Cliente.Nombre);

                    lblnombre.Text = respuesta.Cliente.Nombre + " hols";//respuesta.Cliente.Apellido;
                    lblfecha.Text = respuesta.Cliente.FechaIngreso;
                }
                else
                {
                    logohombre.Visible = false;
                    logomujer.Visible = true;


                    lblnombre.Text = respuesta.Cliente.Nombre + respuesta.Cliente.Apellido;
                    lblfecha.Text = respuesta.Cliente.FechaIngreso;
                }
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
    }
}
