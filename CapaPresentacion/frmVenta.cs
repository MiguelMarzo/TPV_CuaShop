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
            foreach (Control celda in tlpFamilias.Controls)
            {
                Button newBoton = new Button();
                
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAnadirCarrito_Click(object sender, EventArgs e)
        {

            dgvProductos.DataSource = _negocio.DevolverTodosLosArticulos();





            //if (dgvProductos.SelectedRows.Count > 0)
            //{
            //    List<Articulo> articulos = new List<Articulo>();
            //    for (int i = 0; i < dgvProductos.SelectedRows.Count; i++)
            //    {

            //    }
            //}
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpFamilias_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
