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
    public partial class Prueba : Form
    {
        Negocio _negocio = new Negocio();
        public Prueba()
        {
            InitializeComponent();
        }
        private void Prueba_Load(object sender, EventArgs e)
        {
            cargarFamilias();

        }
        private void cargarFamilias()
        {
            var familias = _negocio.devolverFamilias();
            foreach (Familia fam in familias)
            {
                for (int i = 0; i < familias.Count; i++)
                {
                  var famButton = grpFamilias.Controls["btnFamilia" + (i+1)] as Button;
                  famButton.Text = fam.idFamilia;
                  //famButton.BackgroundImage = Image.FromFile(@fam.rutaFoto);                    
                }                
            }

        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = _negocio.DevolverTodosLosArticulos();
        }

        
    }
}
