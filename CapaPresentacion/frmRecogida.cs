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
            var empleados =  _negocio.devolverEmpleados();
            foreach (Empleado empleado in empleados) {
                cmbNumeroEmpleado.Items.Add(empleado);
                cmbNumeroEmpleado.DisplayMember = "[nombreEmpleado]";
            }
            lblNumeroRecogida.Text += ": " + _negocio.maxRecogida();
            cmbEntregador.Items.Add("Profesor");
            cmbEntregador.Items.Add("Alumno");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Empleado empl = new Empleado();
            empl= (Empleado) cmbNumeroEmpleado.SelectedItem;
           
            _negocio.CrearRegistroRecogida(cmbEntregador.SelectedItem.ToString(), short.Parse(txtNumeroArticulosEntregados.Text), (short) empl.numeroEmpleado);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
