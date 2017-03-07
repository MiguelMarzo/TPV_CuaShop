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
    public partial class frmRecogida : Form
    {
        private Negocio _negocio = new Negocio();
        public frmRecogida()
        {
            InitializeComponent();
        }

        private void frmRecogida_Load(object sender, EventArgs e)
        {
            lblEmpleado.Text += StaticGlobal.GlobalVar.numeroEmpleado;
            lblFecha.Text += DateTime.Today.ToShortDateString();
            var empleados =  _negocio.DevolverEmpleados();
            lblNumeroRecogida.Text += ": " + _negocio.MaxRecogida();
            cmbEntregador.Items.Add("Profesor");
            cmbEntregador.Items.Add("Alumno");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           int numeroArticulos;
           if (!int.TryParse(txtNumeroArticulosEntregados.Text, out numeroArticulos))
            {
                MessageBox.Show("Introduce una cantidad de articulos correcta");
                return;
            } else
            {
                MessageBox.Show(_negocio.CrearRegistroRecogida(cmbEntregador.SelectedItem.ToString(), (short) numeroArticulos, (short)StaticGlobal.GlobalVar.numeroEmpleado));
            }
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
