using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmRecogida : Form
    {
        private Negocio _negocio = new Negocio();
        public frmRecogida()
        {
            InitializeComponent();
        }

        private void frmRecogida_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _negocio.CrearRegistroRecogida(cmbEntregador.SelectedItem.ToString(), short.Parse(txtNumeroArticulosEntregados.Text), short.Parse(cmbNumeroEmpleado.SelectedItem.ToString()));
        }
    }
}
