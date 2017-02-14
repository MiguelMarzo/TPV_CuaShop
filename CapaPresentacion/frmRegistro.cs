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
using Entidades;

namespace CapaPresentacion
{
    public partial class frmRegistro : Form
    {
        Negocio _negocio = new Negocio();
        private List<Familia> familias;
        private List<SubFamilia> subFamilias;
        public frmRegistro()
        {
            InitializeComponent();
            cmbFamilia.DisplayMember = "nombreFamilia";
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            subFamilias = new List<SubFamilia>();
            subFamilias = _negocio.devolverSubFamilias();
            cmbSubFamilia.DataSource = subFamilias;
            familias = new List<Familia>();
            familias = _negocio.devolverFamilias();
            cmbFamilia.DataSource = familias;
            
            lblFecha.Text += DateTime.Today.ToShortDateString();
            chkFecha.CheckState = CheckState.Unchecked;
            calFechaCaducidad.Enabled = false;
            //cmbNumeroEmpleado.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (cmbNumeroEmpleado.SelectedText == "")
            {
                MessageBox.Show("Debes indicar el número de empleado");
                return;
            }

            if (txtCodArticulo.Text == "")
            {
                MessageBox.Show("Debes indicar el código del artículo");
                return;
            }

            if (cmbRecogida.SelectedText == "")
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

            var precio = 0;
            if (!Int32.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Debes introducir un precio correcto");
                return;
            }

            var fecha = DateTime.MinValue;
            if (chkFecha.CheckState == CheckState.Checked)
            {
                fecha = calFechaCaducidad.SelectionStart;
            }

            var result =  _negocio.insertarArticulo(txtCodArticulo.Text, txtDescripcion.Text, txtTallaPesoLitros.Text, Int32.Parse(txtCantidad.Text),
            fecha, Int32.Parse(cmbRecogida.SelectedText), Int32.Parse(txtPedido.Text), 0, precio, (Familia) cmbFamilia.SelectedItem, 
            (SubFamilia) cmbSubFamilia.SelectedItem);

            MessageBox.Show(result);
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}