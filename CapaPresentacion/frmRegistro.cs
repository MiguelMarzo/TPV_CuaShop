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
        }
        private void frmRegistro_Load(object sender, EventArgs e)
        {
            lblEmpleado.Text += StaticGlobal.GlobalVar.numeroEmpleado;
            lblFecha.Text += DateTime.Today.ToShortDateString();

            btnVolver.BackgroundImage = new Bitmap("volver.png");
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
            btnAceptar.BackgroundImage = new Bitmap("aceptar.png");
            btnAceptar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAñadirStock.BackgroundImage = new Bitmap("añadir.png");
            btnAñadirStock.BackgroundImageLayout = ImageLayout.Stretch;

            recogidas = _negocio.DevolverRecogidas();
            cmbRecogida.DataSource = recogidas;
            cmbRecogida.DisplayMember = "numeroRecogida";

            familias = new List<Familia>();
            familias = _negocio.DevolverFamilias();
            cmbFamilia.DataSource = familias;
            cmbFamilia.DisplayMember = "nombreFamilia";  
            cmbFamiliaStock.DataSource = familias;
            cmbFamiliaStock.DisplayMember = "nombreFamilia";
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
            var result = _negocio.RegistroNuevoArticulo(txtCodArticulo.Text, txtDescripcion.Text, txtTallaPesoLitros.Text, cantidad,
            recogida.numeroRecogida, numPedido, 0, precio, localizacion, (Familia)cmbFamiliaStock.SelectedItem,
            (SubFamilia)cmbSubFamiliaStock.SelectedItem);

            MessageBox.Show(result);
        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbFamiliaStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            subFamilias = new List<SubFamilia>();
            subFamilias = _negocio.DevolverSubFamiliasPorFamilia((Familia)cmbFamiliaStock.SelectedItem);
            cmbSubFamiliaStock.DataSource = subFamilias;
            cmbSubFamiliaStock.DisplayMember = "nombreSubFamilia";
        }

        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            subFamilias = new List<SubFamilia>();
            subFamilias = _negocio.DevolverSubFamiliasPorFamilia((Familia)cmbFamilia.SelectedItem);
            cmbSubFamilia.DataSource = subFamilias;
            cmbSubFamilia.DisplayMember = "nombreSubFamilia";
        }

        private void cmbSubFamiliaStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _negocio.DevolverArticulosPorSubFamilia((SubFamilia)cmbSubFamiliaStock.SelectedItem);
        }

        private void btnAñadirStock_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (!(int.TryParse(txtCantidadStock.Text, out cantidad)))
            {
                MessageBox.Show("Debes introducir una cantidad adecuada");
                return;
            }
            String result = _negocio.ActualizarStockArticulo(dgvProductos.SelectedCells[0].Value.ToString(), cantidad);
            MessageBox.Show(result);
        }


    }
}