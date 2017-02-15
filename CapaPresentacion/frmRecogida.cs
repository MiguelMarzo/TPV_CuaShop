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
            var empleados =  _negocio.devolverEmpleados();
            lblNumeroRecogida.Text += ": " + _negocio.maxRecogida();
            cmbEntregador.Items.Add("Profesor");
            cmbEntregador.Items.Add("Alumno");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           
            _negocio.CrearRegistroRecogida(cmbEntregador.SelectedItem.ToString(), short.Parse(txtNumeroArticulosEntregados.Text), (short) StaticGlobal.GlobalVar.numeroEmpleado);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
