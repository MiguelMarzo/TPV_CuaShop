﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta : IEquatable<Venta>
    {
        public int numeroVenta { get; set; }
        public int numeroEmpleado { get; set; }
        public DateTime fechaVenta { get; set; }
        public double precio { get; set; }

        public Venta()
        {

        }

        public Venta(int numeroVenta, int numeroEmpleado, DateTime fechaVenta, double precio)
        {
            this.numeroVenta = numeroVenta;
            this.numeroEmpleado = numeroEmpleado;
            this.fechaVenta = fechaVenta;
            this.precio = precio;
        }

        public bool Equals(Venta other)
        {
            if (other == null)
                return false;

            if (this.numeroVenta == other.numeroVenta)
                return true;
            else
                return false;
        }
    }
}
