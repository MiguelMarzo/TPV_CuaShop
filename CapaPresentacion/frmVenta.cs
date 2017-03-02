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
        List<Articulo> carrito = new List<Articulo>();
        List<Familia> familias = new List<Familia>();
        List<SubFamilia> subFamilias = new List<SubFamilia>();
        SubFamilia subFamActual;
        public frmVenta()
        {
            InitializeComponent();
        }
        private void Prueba_Load(object sender, EventArgs e)
        {
            cargarFamilias();
            lblEmpleado.Text += StaticGlobal.GlobalVar.numeroEmpleado;
            lblFecha.Text += DateTime.Today.ToShortDateString();
            articulos = _negocio.DevolverTodosLosArticulos();
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
                famButton.Visible = true;
                //famButton.BackgroundImage = Image.FromFile(@fam.rutaFoto);        
            }
        }
        private void FamButtonClick(object sender, EventArgs e)
        {
            Button famButton = sender as Button;
            dgvProductos.DataSource = null;
            if (famButton.Tag != null)
            {
                foreach (Control btn in grpFamilias.Controls)
                {
                    btn.BackColor = Color.Transparent;
                }
                famButton.BackColor = Color.Aqua;
                subFamilias = _negocio.DevolverSubFamiliasPorFamilia((Familia)famButton.Tag);
                foreach (Control btn in grpSubFamilias.Controls)
                {
                    btn.Text = "";
                    btn.Visible = false;
                    btn.Tag = null;
                    btn.BackColor = Color.Transparent;
                }
                int countBtn = 1;
                foreach (SubFamilia subFam in subFamilias)
                {
                    var subFamButton = grpSubFamilias.Controls["btnSubFamilia" + (countBtn)];
                    countBtn++;
                    subFamButton.Tag = subFam;
                    subFamButton.Text = subFam.nombre;
                    subFamButton.Visible = true;
                }
            }
        }

        private void SubFamButtonClick(object sender, EventArgs e)
        {
            Button subFamButton = sender as Button;
            if (subFamButton.Tag != null)
            {
                foreach (Control btn in grpSubFamilias.Controls)
                {
                    btn.BackColor = Color.Transparent;
                }
                subFamButton.BackColor = Color.Aqua;
                subFamActual = (SubFamilia)subFamButton.Tag;
                List<Articulo> articulosSubFam = articulos.FindAll(x => x.idSubFamilia == subFamActual.idSubFamilia);
                dgvProductos.DataSource = articulosSubFam.Select(o => new
                {
                    Codigo = o.codigoArticulo,
                    Descripción = o.descripcion,
                    Precio = o.precio,
                    Cantidad = o.stock,
                    TallaPesoLitros = o.tallaPesoLitros
                }).ToList();
                if (dgvProductos.Rows.Count > 0) { dgvProductos.Rows[0].Selected = true; }
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CellEnter(object sender, EventArgs e)
        {
            dgvProductos.Rows[dgvProductos.SelectedCells[0].RowIndex].Selected = true;
        }
        private void btnAnadirCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                Articulo art = articulos.Find(x => x.codigoArticulo == dgvProductos.SelectedRows[0].Cells[0].Value.ToString());
                if (art.stock > 0)
                {
                    if (carrito.Contains(art))
                    {
                        carrito.Find(x => x.codigoArticulo == art.codigoArticulo).stock++;
                    }
                    else
                    {
                        Articulo artCarrito = new Articulo(art.codigoArticulo, art.descripcion, art.tallaPesoLitros, 1, art.numeroRecogida,
                            art.numeroPedido, art.numeroVenta, art.precio, art.localizacion, art.idFamilia, art.idSubFamilia);
                        carrito.Add(artCarrito);
                    }
                    art.stock--;
                    dgvCarrito.DataSource = carrito.Select(o => new
                    {
                        Codigo = o.codigoArticulo,
                        Descripción = o.descripcion,
                        Precio = o.precio,
                        Cantidad = o.stock,
                        TallaPesoLitros = o.tallaPesoLitros
                    }).ToList();
                    List<Articulo> articulosSubFam = articulos.FindAll(x => x.idSubFamilia == subFamActual.idSubFamilia);
                    dgvProductos.DataSource = articulosSubFam.Select(o => new
                    {
                        Codigo = o.codigoArticulo,
                        Descripción = o.descripcion,
                        Precio = o.precio,
                        Cantidad = o.stock,
                        TallaPesoLitros = o.tallaPesoLitros
                    }).ToList();
                    if (dgvProductos.Rows.Count > 0) { dgvProductos.Rows[0].Selected = true; }
                    return;
                }
                else
                {
                    MessageBox.Show("No hay stock");
                    return;
                }
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
