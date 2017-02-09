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
        public DateTime fechaCaducidad { get; set; }
        public int numeroRecogida { get; set; }
        public int numeroPedido { get; set; }
        public int numeroVenta { get; set; }
        public decimal precio { get; set; }
        public int iva { get; set; }

        public Articulo()
        {

        }

        public Articulo(string codigoArticulo, string descripcion, string tallaPesoLitros, int stock,
            DateTime fechaCaducidad, int numeroRecogida, int numeroPedido, int numeroVenta, decimal precio,int iva)
        {
            this.codigoArticulo = codigoArticulo;
            this.descripcion = descripcion;
            this.tallaPesoLitros = tallaPesoLitros;
            this.stock = stock;
            this.fechaCaducidad = fechaCaducidad;
            this.numeroRecogida = numeroRecogida;
            this.numeroPedido = numeroPedido;
            this.numeroVenta = numeroVenta;
            this.precio = precio;
            this.iva = iva;
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
