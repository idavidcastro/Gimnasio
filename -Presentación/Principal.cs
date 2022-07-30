using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _Presentación
{
    public partial class Principal : Form
    {
        public Principal()
        {

            InitializeComponent();
            Entrada entrada = new Entrada();
            MostrarFormulario(entrada);
            

        }

        public void MostrarFormulario(Form formulario)
        {
            if (panel4.Controls.Count > 0)
            {
                panel4.Controls.RemoveAt(0);
            }

            formulario.TopLevel = false;
            this.panel4.Controls.Add(formulario);
            formulario.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AbrirFormHijo(object Formhijo)
        {
            if (this.panel4.Controls.Count > 0)
                this.panel4.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel4.Controls.Add(fh);
            this.panel4.Tag = fh;
            fh.Show();
        }
       
            private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Registro());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Tipos_de_plancs ());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Consultar());
        }

      
      

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnrestaurar.Visible = true;
            btnmaximizar.Visible = false;
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            btnmaximizar.Visible = true;
        }

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Entrada());
        }

        private void Panelmedio(object sender, PaintEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new CodigoQR());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Asistencia());
        }
    }
}
