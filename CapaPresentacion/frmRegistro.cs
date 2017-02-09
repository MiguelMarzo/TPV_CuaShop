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

            if (cmbNumeroEmpleado.SelectedItem == null)
            {
                MessageBox.Show("Debes indicar el número de empleado");
                return;
            }

            if (txtCodArticulo.Text == "")
            {
                MessageBox.Show("Debes indicar el código del artículo");
                return;
            }

            if (txtNumeroRecogida.Text == "")
            {
                MessageBox.Show("Debes indicar el número de recogida");
                return;
            }

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debes indicar la descripción del artículo");
                return;
            }

            if (txtTallaPesoLitros.Text == "")
            {
                MessageBox.Show("Debes indicar la talla, el peso o los litros que tiene el artículo");
                return;
            }

            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Debes indicar la cantidad del artículo");
                return;
            }

            //if (txtFechaCaducidad.Text == "")
            //{
            //    MessageBox.Show("Debes indicar la fecha de caducidad del artículo");
            //    return;
            //}

            if (_negocio.existeArticulo(txtCodArticulo.Text) == "Existe")
            {
                _negocio.actualizarStockArticulo(txtCodArticulo.Text, short.Parse(txtCantidad.Text));
            }else
            {
                //_negocio.insertarArticulo(txtCodArticulo.Text, txtDescripcion.Text, txtTallaPesoLitros.Text, txtCantidad.Text, DateTime.Parse(txtFechaCaducidad.Text), txtNumeroRecogida.Text, 0, 0, , );
            }

        }
    }
}
