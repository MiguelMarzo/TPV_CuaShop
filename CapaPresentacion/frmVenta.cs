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
    public partial class frmVenta : Form
    {
        Negocio _negocio = new Negocio();
        List<Articulo> articulos = new List<Articulo>();
        List<Familia> familias = new List<Familia>();
        List<SubFamilia> subFamilias = new List<SubFamilia>();
        public frmVenta()
        {
            InitializeComponent();
        }
        private void Prueba_Load(object sender, EventArgs e)
        {

            cargarFamilias();
            dgvProductos.DataSource = _negocio.DevolverTodosLosArticulos();
            lblEmpleado.Text += StaticGlobal.GlobalVar.numeroEmpleado;
            lblFecha.Text += DateTime.Today.ToShortDateString();

        }
        private void cargarFamilias()
        {
            familias = _negocio.DevolverFamilias();
            int countBtn = 1;
            foreach (Familia fam in familias)
            {
                var famButton = grpFamilias.Controls["btnFamilia" + (countBtn)] as Button;
                countBtn++;
                famButton.Tag = fam;
                famButton.Text = fam.nombreFamilia;
                //famButton.BackgroundImage = Image.FromFile(@fam.rutaFoto);        
            }
        }
        private void FamButtonClick(object sender, EventArgs e)
        {
            Button famButton = sender as Button;
            if (famButton.Tag != null)
            {
                subFamilias = _negocio.DevolverSubFamiliasPorFamilia((Familia)famButton.Tag);
                foreach (Control btn in grpSubFamilias.Controls)
                {
                    btn.Text = "";
                    btn.Tag = null;
                }
                int countBtn = 1;
                foreach (SubFamilia subFam in subFamilias)
                {
                    var subFamButton = grpSubFamilias.Controls["btnSubFamilia" + (countBtn)];
                    countBtn++;
                    subFamButton.Tag = subFam;
                    subFamButton.Text = subFam.nombre;
                }
            }
        }

        private void SubFamButtonClick(object sender, EventArgs e)
        {
            Button subFamButton = sender as Button;
            if (subFamButton.Tag != null)
            {
                dgvProductos.DataSource = _negocio.DevolverArticulosPorSubFamilia((SubFamilia)subFamButton.Tag);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAnadirCarrito_Click(object sender, EventArgs e)
        {

            if (Convert.ToInt32(dgvProductos.CurrentRow.Cells["stock"].Value) > 0)
            {
                Articulo articulo = new Articulo();
                articulo.codigoArticulo = Convert.ToString(dgvProductos.CurrentRow.Cells["codigoArticulo"].Value);
                articulo.descripcion = Convert.ToString(dgvProductos.CurrentRow.Cells["descripcion"].Value);
                articulo.tallaPesoLitros = Convert.ToString(dgvProductos.CurrentRow.Cells["tallaPesoLitros"].Value);
                articulo.stock = Convert.ToInt32(dgvProductos.CurrentRow.Cells["stock"].Value);
                articulo.numeroPedido = Convert.ToInt32(dgvProductos.CurrentRow.Cells["numeroPedido"].Value);
                articulo.numeroRecogida = Convert.ToInt32(dgvProductos.CurrentRow.Cells["numeroRecogida"].Value);
                articulo.numeroVenta = Convert.ToInt32(dgvProductos.CurrentRow.Cells["numeroVenta"].Value);
                articulo.precio = Convert.ToInt32(dgvProductos.CurrentRow.Cells["precio"].Value);
                articulo.idIva = Convert.ToInt32(dgvProductos.CurrentRow.Cells["idIva"].Value);
                articulo.localizacion = Convert.ToString(dgvProductos.CurrentRow.Cells["localizacion"].Value);
                articulo.idFamilia = Convert.ToString(dgvProductos.CurrentRow.Cells["idFamilia"].Value);
                articulo.idSubFamilia = Convert.ToString(dgvProductos.CurrentRow.Cells["idSubFamilia"].Value);
                dgvProductos.CurrentRow.Cells["stock"].Value = Convert.ToInt32(dgvProductos.CurrentRow.Cells["stock"].Value) - 1;
                articulos.Add(articulo);
                dgvCarrito.DataSource = null;
                dgvCarrito.DataSource = articulos;
            }
            else
            {
                MessageBox.Show("STOCK 0");
            }
        }

        private void btnDevolverAProductos_Click(object sender, EventArgs e)
        {

            if (articulos.Count > 0)
            {

                String CodigoArticulo = Convert.ToString(dgvCarrito.CurrentRow.Cells["codigoArticulo"].Value);
                Articulo articulo = _negocio.DevolverArticuloPorCodigo(CodigoArticulo);
                articulo.stock = articulo.stock + 1;

                articulos.RemoveAt(dgvCarrito.CurrentRow.Index);
                dgvCarrito.DataSource = null;
                dgvCarrito.DataSource = articulos;
            }

        }

        private void btnSacarTicket_Click(object sender, EventArgs e)
        {

        }
    }
}
