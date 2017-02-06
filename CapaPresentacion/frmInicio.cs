using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccionesEmpleado_Click(object sender, EventArgs e)
        {
            frmAccionesEmpleado accionesEmpleado = new frmAccionesEmpleado();
            accionesEmpleado.Show();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            frmBuscarArticulo buscarArticulo = new frmBuscarArticulo();
            buscarArticulo.Show();
        }
    }
}
