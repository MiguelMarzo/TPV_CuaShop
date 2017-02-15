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
    public partial class frmLogin : Form
    {
        private Negocio _negocio = new Negocio();
        private List<Empleado> empleados = new List<Empleado>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            empleados = _negocio.devolverEmpleados();
            int i = 0;
            foreach (Empleado emp in empleados)
            {                
                Button btnAdd = new Button();
                btnAdd.BackColor = Color.Gray;
                btnAdd.Text = "Add";
                btnAdd.Location = new System.Drawing.Point(90, 25 + i);
                btnAdd.Size = new System.Drawing.Size(50, 25);
                grpEmpleados.Controls.Add(btnAdd);
                i = i + 10;
            }
        }
    }
}
