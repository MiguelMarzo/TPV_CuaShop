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
            txtNumPedido.Enabled = false;
            txtNumRecogida.Enabled = false;
            txtNumVenta.Enabled = false;
            cmbSubFamilia.Enabled = false;

            List<Familia> familias = _negocio.DevolverFamilias();

            foreach(Familia fam in familias)
            {
                cmbFamilia.Items.Add(fam);
            }

            List<Iva> ivas = _negocio.DevolverIvas();

            foreach(Iva iva in ivas)
            {
                cmbIVA.Items.Add(iva);
            }
        }

        private void chbDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDescripcion.Checked)
            {
                txtDescripcion.Enabled = true;
            }else
            {
                txtDescripcion.Enabled = false;
                txtDescripcion.Text = "";
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
                cmbFamilia.Text = "";
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
                cmbSubFamilia.Text = "";
            }
        }

        private void chbNumRecogida_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNumRecogida.Checked)
            {
                txtNumRecogida.Enabled = true;
            }
            else
            {
                txtNumRecogida.Enabled = false;
                txtNumRecogida.Text = "";
            }
        }

        private void chbNumPedido_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNumPedido.Checked)
            {
                txtNumPedido.Enabled = true;
            }
            else
            {
                txtNumPedido.Enabled = false;
                txtNumPedido.Text = "";
            }
        }

        private void chbNumVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chbNumVenta.Checked)
            {
                txtNumVenta.Enabled = true;
            }
            else
            {
                txtNumVenta.Enabled = false;
                txtNumPedido.Text = "";
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
                cmbIVA.Text = "";
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
                txtEstanteria.Text = "";
                txtEstante.Text = "";
                txtAltura.Text = "";
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
            txtNumPedido.Enabled = false;
            txtNumRecogida.Enabled = false;
            txtNumVenta.Enabled = false;
            cmbSubFamilia.Enabled = false;
            cmbSubFamilia.Enabled = false;

            txtAltura.Text = "";
            txtDescripcion.Text = "";
            txtEstante.Text = "";
            txtEstanteria.Text = "";
            cmbFamilia.Text = "";
            cmbIVA.Text = "";
            txtNumPedido.Text = "";
            txtNumRecogida.Text = "";
            txtNumVenta.Text = "";
            cmbSubFamilia.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int estanteria;
            int estante;
            int altura;
            Familia familia;
            SubFamilia subFamilia;
            Iva iva;
            Int32 recogida;
            Int32 numPedido;
            Int32 venta;

            Int32.TryParse(txtEstanteria.Text, out estanteria);
            Int32.TryParse(txtEstante.Text, out estante);
            Int32.TryParse(txtAltura.Text, out altura);

            if((Familia)cmbFamilia.SelectedItem == null)
            {
                familia = new Familia("", "", "", "");
            }else
            {
                familia = (Familia)cmbFamilia.SelectedItem;
            }

            if((SubFamilia)cmbSubFamilia.SelectedItem == null)
            {
                subFamilia = new SubFamilia("", "", "", -1, "");
            }else
            {
                subFamilia = (SubFamilia)cmbSubFamilia.SelectedItem;
            }

            if((Iva)cmbIVA.SelectedItem == null)
            {
                iva = new Iva(-1, "");
            }else
            {
                iva = (Iva)cmbIVA.SelectedItem;
            }

            if(txtNumRecogida.Text == "")
            {
                recogida = -1;
            }else
            {
                recogida = Int32.Parse(txtNumRecogida.Text);
            }

            if(txtNumPedido.Text == "")
            {
                numPedido = -1;
            }else
            {
                numPedido = Int32.Parse(txtNumPedido.Text);
            }

            if(txtNumVenta.Text == "")
            {
                venta = -1;
            }else
            {
                venta = Int32.Parse(txtNumVenta.Text);
            }

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

            List<Articulo> articulos = _negocio.BuscarArticuloEspecifico(txtDescripcion.Text, familia, subFamilia, recogida, numPedido, venta, iva, estanteria, estante, altura);

            dgvArticulos.DataSource = articulos;
        }
        
        private void cmbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SubFamilia> subFamilias = _negocio.DevolverSubFamiliasPorFamilia((Familia) cmbFamilia.SelectedItem);
        }
    }
}
