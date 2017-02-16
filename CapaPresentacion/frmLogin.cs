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
            empleados = _negocio.DevolverEmpleados();
            int i = 0;
            foreach (Empleado emp in empleados)
            {
                if (emp.rutaFoto != "nope")
                {
                    Button btnAdd = new Button();
                    btnAdd.Tag = emp;
                    btnAdd.BackColor = Color.Gray;
                    btnAdd.Size = new System.Drawing.Size(100, 100);
                    //btnAdd.BackgroundImage = new Bitmap(emp.rutaFoto);
                    btnAdd.BackgroundImageLayout = ImageLayout.Stretch;
                    btnAdd.Click += button_click;
                    if (grpEmpleados.Controls.Count >= 6)
                    {
                        btnAdd.Location = new System.Drawing.Point(10 + i, 135);
                    }
                    else
                    {
                        btnAdd.Location = new System.Drawing.Point(10 + i, 25);
                    }
                    i = i + 110;
                    if (i >= 600)
                    {
                        i = 0;
                    }

                    grpEmpleados.Controls.Add(btnAdd);
                }           
            }
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btnClicked = sender as Button;
            StaticGlobal.GlobalVar = (Empleado) btnClicked.Tag;
            frmInicio inicio = new frmInicio();
            inicio.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
