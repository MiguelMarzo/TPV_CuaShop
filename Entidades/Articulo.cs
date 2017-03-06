using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo : IEquatable<Articulo>
    {        
        public string codigoArticulo { get; set;}
        public string descripcion { get; set; }
        public string tallaPesoLitros { get; set; }
        public int stock { get; set; }
        public int numeroRecogida { get; set; }
        public int numeroPedido { get; set; }
        public decimal precio { get; set; }
        public int idIva { get; set; }
        public String localizacion { get; set; }
        public String idFamilia { get; set; }
        public String idSubFamilia { get; set; }

        public Articulo()
        {

        }

        public Articulo(string codigoArticulo, string descripcion, string tallaPesoLitros, int stock,
            int numeroRecogida, int numeroPedido, decimal precio, String localizacion, String idFamilia, 
            String idSubFamilia)
        {
            this.codigoArticulo = codigoArticulo;
            this.descripcion = descripcion;
            this.tallaPesoLitros = tallaPesoLitros;
            this.stock = stock;
            this.numeroRecogida = numeroRecogida;
            this.numeroPedido = numeroPedido;
            this.precio = precio;
            this.localizacion = localizacion;
            this.idFamilia = idFamilia;
            this.idSubFamilia = idSubFamilia;
        }

        public bool Equals(Articulo other)
        {
            if (other == null)
                return false;

            if (this.codigoArticulo == other.codigoArticulo)
                return true;
            else
                return false;
        }


    }
}
