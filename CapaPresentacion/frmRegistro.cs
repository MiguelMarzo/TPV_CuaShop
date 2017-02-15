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
        private List<Recogida> recogidas;
        public frmRegistro()
        {
            InitializeComponent();
            cmbFamilia.DisplayMember = "nombreFamilia";
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            lblEmpleado.Text += StaticGlobal.GlobalVar.numeroEmpleado;
            subFamilias = new List<SubFamilia>();
            subFamilias = _negocio.devolverSubFamilias();
            cmbSubFamilia.DataSource = subFamilias;
            familias = new List<Familia>();
            familias = _negocio.devolverFamilias();
            recogidas = _negocio.devolverRecogidas();
            cmbRecogida.DataSource = recogidas;
            cmbRecogida.DisplayMember = "numeroRecogida";
            cmbFamilia.DataSource = familias;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int estanteria = 0;
            int estante = 0;
            int altura = 0;
            if ((txtEstante.Text == "") || (txtEstanteria.Text == "") || (txtAltura.Text == "") || !(int.TryParse(txtEstanteria.Text, out estanteria)) ||
                !(int.TryParse(txtEstante.Text, out estante)) || !(int.TryParse(txtAltura.Text, out altura)))
            {
                MessageBox.Show("Estante, estanteria o altura incorrectos");
                return;
            }
            String localizacion = estanteria + "." + estante + "." + altura;

            if (txtCodArticulo.Text == "")
            {
                MessageBox.Show("Debes indicar el código del artículo");
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

            Decimal precio = 0;
            if (!Decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Debes introducir un precio correcto");
                return;
            }
            Recogida recogida = new Recogida();
            recogida = (Recogida) cmbRecogida.SelectedItem;
            int cantidad = int.Parse(txtCantidad.Text);
            int numPedido;
            if (!(int.TryParse(txtPedido.Text, out numPedido)))
            {
                numPedido = 0;
            }
            var result = _negocio.insertarArticulo(txtCodArticulo.Text, txtDescripcion.Text, txtTallaPesoLitros.Text, cantidad,
            recogida.numeroRecogida, numPedido, 0, precio, localizacion, (Familia)cmbFamilia.SelectedItem,
            (SubFamilia)cmbSubFamilia.SelectedItem);

            MessageBox.Show(result);
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}