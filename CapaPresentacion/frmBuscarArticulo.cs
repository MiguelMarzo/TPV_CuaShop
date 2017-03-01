using CapaNegocio;
using Entidades;
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
    public partial class frmBuscarArticulo : Form
    {

        Negocio _negocio = new Negocio();

        public frmBuscarArticulo()
        {
            InitializeComponent();
        }

        private void frmBuscarArticulo_Load(object sender, EventArgs e)
        {
            chbDescripcion.Checked = false;
            chbFamilia.Checked = false;
            chbIVA.Checked = false;
            chbLocalizacion.Checked = false;
            chbNumPedido.Checked = false;
            chbNumRecogida.Checked = false;
            chbNumVenta.Checked = false;
            chbSubFamilia.Checked = false;

            txtAltura.Enabled = false;
            txtDescripcion.Enabled = false;
            txtEstante.Enabled = false;
            txtEstanteria.Enabled = false;
            cmbFamilia.Enabled = false;
            cmbIVA.Enabled = false;
            cmbNumPedido.Enabled = false;
            cmbNumRecogida.Enabled = false;
            cmbNumVenta.Enabled = false;
            cmbSubFamilia.Enabled = false;
        }

        private void chbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDescripcion.Checked)
            {
                txtDescripcion.Enabled = true;
            }else
            {
                txtDescripcion.Enabled = false;
            }
        }

        private void chbFamilia_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFamilia.Checked)
            {
                cmbFamilia.Enabled = true;
                chbSubFamilia.Enabled = true;
            }
            else
            {
                cmbFamilia.Enabled = false;
                chbSubFamilia.Enabled = false;
                chbSubFamilia.Checked = false;
            }
        }

        private void chbSubFamilia_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSubFamilia.Checked)
            {
                cmbSubFamilia.Enabled = true;
            }
            else
            {
                cmbSubFamilia.Enabled = false;
            }
        }

        private void chbNumRecogida_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNumRecogida.Checked)
            {
                cmbNumRecogida.Enabled = true;
            }
            else
            {
                cmbNumRecogida.Enabled = false;
            }
        }

        private void chbNumPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNumPedido.Checked)
            {
                cmbNumPedido.Enabled = true;
            }
            else
            {
                cmbNumPedido.Enabled = false;
            }
        }

        private void chbNumVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNumVenta.Checked)
            {
                cmbNumVenta.Enabled = true;
            }
            else
            {
                cmbNumVenta.Enabled = false;
            }
        }

        private void chbIVA_CheckedChanged(object sender, EventArgs e)
        {
            if (chbIVA.Checked)
            {
                cmbIVA.Enabled = true;
            }
            else
            {
                cmbIVA.Enabled = false;
            }
        }

        private void chbLocalizacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbLocalizacion.Checked)
            {
                txtEstanteria.Enabled = true;
                txtEstante.Enabled = true;
                txtAltura.Enabled = true;
            }
            else
            {
                txtEstanteria.Enabled = false;
                txtEstante.Enabled = false;
                txtAltura.Enabled = false;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            chbDescripcion.Checked = false;
            chbFamilia.Checked = false;
            chbIVA.Checked = false;
            chbLocalizacion.Checked = false;
            chbNumPedido.Checked = false;
            chbNumRecogida.Checked = false;
            chbNumVenta.Checked = false;
            chbSubFamilia.Checked = false;

            txtAltura.Enabled = false;
            txtDescripcion.Enabled = false;
            txtEstante.Enabled = false;
            txtEstanteria.Enabled = false;
            cmbFamilia.Enabled = false;
            cmbIVA.Enabled = false;
            cmbNumPedido.Enabled = false;
            cmbNumRecogida.Enabled = false;
            cmbNumVenta.Enabled = false;
            cmbSubFamilia.Enabled = false;
            cmbSubFamilia.Enabled = false;

            txtAltura.Text = "";
            txtDescripcion.Text = "";
            txtEstante.Text = "";
            txtEstanteria.Text = "";
            cmbFamilia.Text = "";
            cmbIVA.Text = "";
            cmbNumPedido.Text = "";
            cmbNumRecogida.Text = "";
            cmbNumVenta.Text = "";
            cmbSubFamilia.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int estanteria;
            int estante;
            int altura;

            Int32.TryParse(txtEstanteria.Text, out estanteria);
            Int32.TryParse(txtEstante.Text, out estante);
            Int32.TryParse(txtAltura.Text, out altura);

            if(estanteria == 0)
            {
                estanteria = -1;
            }

            if(estante == 0)
            {
                estante = -1;
            }

            if(altura == 0)
            {
                altura = -1;
            }

            List<Articulo> articulos = _negocio.BuscarArticuloEspecifico(txtDescripcion.Text, (Familia)cmbFamilia.SelectedItem, (SubFamilia)cmbSubFamilia.SelectedItem, (int)cmbNumRecogida.SelectedItem, (int)cmbNumPedido.SelectedItem, (int)cmbNumVenta.SelectedItem, (Iva)cmbIVA.SelectedItem, estanteria, estante, altura);

            dgvArticulos.DataSource = articulos;
        }
    }
}
