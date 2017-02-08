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
    public partial class frmRegistro : Form
    {
        Negocio _negocio = new Negocio();
        public frmRegistro()
        {
            InitializeComponent();
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            lblFecha.Text += DateTime.Today.ToShortDateString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           // _negocio.registrarArticulo(txtCodArticulo.Text, txtDescripcion.Text, cmbCantidad.SelectedItem, 
           //     txtNumeroRecogida.Text, txtTallaPesoLitros.Text, txtFechaCaducidad.Text, cmbNumeroEmpleado.SelectedItem);



        }
    }
}
