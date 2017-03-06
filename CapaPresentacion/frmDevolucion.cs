using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmDevolucion : Form
    {
        private Negocio _negocio = new Negocio();
        private List<Articulo> articulos = new List<Articulo>();
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            lblEmpleado.Text += StaticGlobal.GlobalVar.numeroEmpleado;
            lblFecha.Text += DateTime.Today.ToShortDateString();
            articulos = _negocio.DevolverTodosLosArticulos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvArticulos.DataSource = articulos.FindAll(a => (a.codigoArticulo.Contains(txtCodigo.Text))).Select(o => new
            {
                Codigo = o.codigoArticulo,
                Descripción = o.descripcion,
                Precio = o.precio,
                Cantidad = o.stock,
                TallaPesoLitros = o.tallaPesoLitros,
                Localizacion = o.localizacion
            }).ToList();
            if (dgvArticulos.Rows.Count > 0) { dgvArticulos.Rows[dgvArticulos.SelectedCells[0].RowIndex].Selected = true; };
        }

        private void CellEnterArticulos(object sender, EventArgs e)
        {
            if (dgvArticulos.Rows.Count > 0) { dgvArticulos.Rows[dgvArticulos.SelectedCells[0].RowIndex].Selected = true; };
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_negocio.DevolverArticulo(dgvArticulos.SelectedCells[0].Value.ToString()));
        }
    }
}
