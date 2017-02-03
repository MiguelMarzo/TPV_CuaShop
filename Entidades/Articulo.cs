using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Articulo : IEquatable<Articulo>
    {
        private int codigoArticulo;
        private string descripcion;
        private string tallaPesoLitros;
        private int stock;
        private DateTime fechaCaducidad;
        private int numeroRecogida;
        private int numeroPedido;
        private int numeroVenta;
        private double precio;

        public Articulo()
        {

        }

        public Articulo(int codigoArticulo, string descripcion, string tallaPesoLitros, int stock,
            DateTime fechaCaducidad, int numeroRecogida, int numeroPedido, int numeroVenta, double precio)
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
