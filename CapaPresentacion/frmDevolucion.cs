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
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            lblEmpleado.Text += StaticGlobal.GlobalVar.numeroEmpleado;
            lblFecha.Text += DateTime.Today.ToShortDateString();
            dataGridView1.DataSource = _negocio.DevolverTodosLosArticulos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            var numeroArticulo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            var precio = dataGridView1.CurrentRow.Cells[8].Value;
            var res2 = _negocio.actualizarPrecioVenta((int.Parse(textBox1.Text)), (int) precio);

            dataGridView1.DataSource = _negocio.devolverVenta(textBox1.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _negocio.devolverVenta(textBox1.Text);
        }
    }
}
