using System;
using CapaNegocio;
using Entidades;
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

        Negocio _negocio = new Negocio();

        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _negocio.DevolverTodosLosArticulos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnadirCarrito_Click(object sender, EventArgs e)
        {
            
                List<Articulo> articulos = new List<Articulo>();
                for (int i = 0; i < dgvProductos.SelectedRows.Count; i++)
                {
                    
                }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
