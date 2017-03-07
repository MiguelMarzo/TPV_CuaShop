using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Entidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmInicio : Form
    {
        private Negocio _negocio = new Negocio();
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccionesEmpleado_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            frmBuscarArticulo buscarArticulo = new frmBuscarArticulo();
            buscarArticulo.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //Primero comprueba usuario, luego contraseña, pero almacena temporalmente el admin entero en el formulario
            Admin admin = _negocio.ComprobarAdminUsuario(Interaction.InputBox("Introduce el usuario", "Admin Log-In", "Usuario"));
            if (admin != null)
            {
                String userPass = Interaction.InputBox("Introduce la contraseña", "Admin Log-In", "Contraseña");
                if (userPass == admin.contraseña)
                {
                    MessageBox.Show("Login correcto, bievenido " + admin.usuario);
                    frmAdmin adminForm = new frmAdmin();
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Usuario Administrador no econtrado");
            }

            //Solo un metodo, sin comprobar usuario primero pero sin almacenar la contraseña correcta en el formulario
            //(Teóricamente más seguro)

            //String userAdmin = Interaction.InputBox("Introduce el usuario", "Admin Log-In", "Usuario");
            //String userPass = Interaction.InputBox("Introduce la contraseña", "Admin Log-In", "Contraseña");
            //if (_negocio.AdminLogin(userAdmin, userPass))
            //{
            //    frmAdmin admin = new frmAdmin();
            //    admin.Show();
            //} else
            //{
            //    MessageBox.Show("Usuario o contraseña incorrecto/s");
            //}
        }
    }
}
