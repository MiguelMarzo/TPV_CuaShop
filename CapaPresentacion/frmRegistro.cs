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
            chkFecha.CheckState = CheckState.Unchecked;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {


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

            var fecha = DateTime.MinValue;
            if (chkFecha.CheckState == CheckState.Checked)
            {
                fecha = calFechaCaducidad.SelectionStart;
            }

            if (_negocio.existeArticulo(txtCodArticulo.Text) == "Existe")
            {
                _negocio.actualizarStockArticulo(txtCodArticulo.Text, short.Parse(txtCantidad.Text));
            }
            else
            {
                _negocio.insertarArticulo(txtCodArticulo.Text, txtDescripcion.Text, txtTallaPesoLitros.Text, Int32.Parse(txtCantidad.Text),
               fecha, Int32.Parse(txtNumeroRecogida.Text), Int32.Parse(txtPedido.Text), 0, Decimal.Parse(txtPrecio.Text), 0);
            }

        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFecha.CheckState == CheckState.Checked)
            {
                calFechaCaducidad.Enabled = true;
            }
            else
            {
                calFechaCaducidad.Enabled = false;
            }
        }
    }
}