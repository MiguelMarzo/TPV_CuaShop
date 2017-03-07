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
using System.Text.RegularExpressions;

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
            pctBoxFotoEmpleado.Image = Image.FromFile(txtRutaFoto.Text);
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
                String[] imagenSeleccionada = Regex.Split(txtRutaFoto.Text, @"(?<=[\\])");
                String fileName = imagenSeleccionada[imagenSeleccionada.Count() - 1];
                imagenSeleccionada.ToList().RemoveAt(imagenSeleccionada.Count() - 1);
                String sourcePath = "";
                for (int i = 0; i<imagenSeleccionada.Count() -1; i++)
                {
                    sourcePath += imagenSeleccionada[i];
                }
                String targetPath = ".";              
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);            
 
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                //Copiar
                System.IO.File.Copy(sourceFile, destFile, true);
                String resultado = _negocio.InsertarEmpleado(txtNombreEmpleado.Text, fileName);
                MessageBox.Show(resultado);
            }
        }

        private void btnEliminarTodosLosEmpleados_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Eliminar todos los empleados?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(_negocio.BorrarEmpleados());
            }
        }
    }
}
