﻿using System;
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
    public partial class frmAccionesEmpleado : Form
    {
        public frmAccionesEmpleado()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.Show();
        }

        private void btnRecogida_Click(object sender, EventArgs e)
        {
            frmRecogida recogida = new frmRecogida();
            recogida.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta();
            venta.Show();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            frmDevolucion devolucion = new frmDevolucion();
            devolucion.Show();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccionesEmpleado_Load(object sender, EventArgs e)
        {
            btnVolver.BackgroundImage = new Bitmap("volver.png");
            btnVolver.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
