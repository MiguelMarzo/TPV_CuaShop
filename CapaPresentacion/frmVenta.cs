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
    public partial class frmVenta : Form
    {

        public Negocio _negocio = new Negocio();
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            List<Articulo> articulos = _negocio.DevolverTodosLosArticulos();
            dgvProductos.DataSource = articulos;
        }

        private void btnAnadirCarrito_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows == null){
                MessageBox.Show("No has seleccionado ningún producto de la lista.");
                return;
            }
        }
    }
}
