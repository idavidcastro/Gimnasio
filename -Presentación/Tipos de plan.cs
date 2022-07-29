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
    public partial class Tipos_de_plancs : Form
    {
        public Tipos_de_plancs()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text == "")
                MessageBox.Show("Debe ingresar un Nombre .....!!!!");
            else if (txtplan.Text == "")
                MessageBox.Show("Debe ingresar un plan ...!!!!");
            else if (txtvalor.Text == "")
                MessageBox.Show("Debe ingresar un valor ...!!!!");

            else
            {
                //capturando datos//
                string codigo = txtcodigo.Text;
                string plan = txtplan.Text;
                string valor = txtvalor.Text;


                dataGridView1.Rows.Add();
                int cantfilas = dataGridView1.Rows.Count - 1;
                dataGridView1[0, cantfilas].Value = txtcodigo.Text;
                dataGridView1[1, cantfilas].Value = txtplan.Text;
                dataGridView1[2, cantfilas].Value = txtvalor.Text;

            }
        }
    }
}
