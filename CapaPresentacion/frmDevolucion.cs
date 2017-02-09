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
            var empleados = _negocio.devolverEmpleados();
            foreach (Empleado empleado in empleados)
            {
                cmbNumeroEmpleado.Items.Add(empleado);
                cmbNumeroEmpleado.DisplayMember = "[nombreEmpleado]";
            }
            lblFechaR.Text = ": " + DateTime.Today.ToShortDateString();
            dataGridView1.DataSource = _negocio.DevolverTodosLosArticulos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
