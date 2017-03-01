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
    public partial class frmAdmin : Form
    {
        private Negocio _negocio = new Negocio();
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnAñadirFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                if ((fdlg.FileName.EndsWith(".png") || fdlg.FileName.EndsWith(".jpeg") || fdlg.FileName.EndsWith(".jpg")
                || fdlg.FileName.EndsWith(".gif")))
                {
                    txtRutaFoto.Text = fdlg.FileName;
                } else
                {
                    MessageBox.Show("Debes elegir un archivo con formato adecuado (.png, .jpeg, .jpg o .gif");
                    return;
                }                
            } 
        }

        private void grpAñadirEmpleado_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpleado.Text == "")
            {
                MessageBox.Show("Introduce un nombre de empleado");
                return;
            } else
            {
                //String resultado = _negocio.InsertarEmpleado(txtNombreEmpleado.Text, txtRutaFoto.Text);
                //MessageBox.Show(resultado);
            }
        }
    }
}
