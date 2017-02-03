using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Articulo : IEquatable<Articulo>
    {
        private string codigoArticulo;
        private string descripcion;
        private string tallaPesoLitros;
        private int stock;
        private DateTime fechaCaducidad;
        private int numeroRecogida;
        private int numeroPedido;
        private int numeroVenta;
        private decimal precio;

        public Articulo()
        {

        }

        public Articulo(string codigoArticulo, string descripcion, string tallaPesoLitros, int stock,
            DateTime fechaCaducidad, int numeroRecogida, int numeroPedido, int numeroVenta, decimal precio)
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
