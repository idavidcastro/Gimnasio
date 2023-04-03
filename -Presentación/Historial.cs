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

namespace _Presentación
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {

        }

        public string Identificacion { get; internal set; }
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }
        public Plan PlanCliente { get; internal set; }
        public string FechaIngreso { get; internal set; }
    }
}
