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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
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
            else if (txtbarrio.Text == "")
                MessageBox.Show("Debe ingresar un Barrio...!!!!");
            else if (txtplan.Text == "")
                MessageBox.Show("Debe ingresar un Plan  ...!!!!");
            else
            {
                //capturando datos//
                string Nombre = txtnombre.Text;
                string Apellido = txtapellido.Text;
                string identificacion = txtidentificacion.Text;
                string sexo = cmbsexo.Text;
                string telefono = txttelefono.Text;
                string edad = txtedad.Text;
                string barrio = txtbarrio.Text;
                string plan = txtplan.Text;


                dataGridView1.Rows.Add();

                int cantfilas = dataGridView1.Rows.Count - 1;

                dataGridView1[0, cantfilas].Value = txtnombre.Text;
                dataGridView1[1, cantfilas].Value = txtapellido.Text;
                dataGridView1[2, cantfilas].Value = txtidentificacion.Text;
                dataGridView1[3, cantfilas].Value = cmbsexo.Text;
                dataGridView1[4, cantfilas].Value = txttelefono.Text;
                dataGridView1[5, cantfilas].Value = txtedad.Text;
                dataGridView1[6, cantfilas].Value = txtbarrio.Text;
                dataGridView1[7, cantfilas].Value = txtplan.Text;
                dataGridView1[8, cantfilas].Value = lblfecha.Text;

                txtnombre.Text = "";
              txtapellido.Text = "";
                 txtidentificacion.Text = "";
               cmbsexo.Text = "";
                txttelefono.Text = "";
                 txtedad.Text = "";
               txtbarrio.Text = "";
               txtplan.Text = "";
            }

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
    }
}
