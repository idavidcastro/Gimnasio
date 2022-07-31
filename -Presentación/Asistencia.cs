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
    public partial class Asistencia : Form
    {
        public Asistencia()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Asistenciapersonal());

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
    }
}
