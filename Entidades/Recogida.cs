using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recogida : IEquatable<Recogida>
    {
        private int numeroRecogida;
        private DateTime fecha;
        private int cantidadArticulos;
        private string entregador;
        private int numeroEmpleado;

        public Recogida(int numeroRecogida, DateTime fecha, int cantidadArticulos, string entregador, int numeroEmpleado)
        {
            this.numeroRecogida = numeroRecogida;
            this.fecha = fecha;
            this.cantidadArticulos = cantidadArticulos;
            this.entregador = entregador;
            this.numeroEmpleado = numeroEmpleado;
        }

        public bool Equals(Recogida other)
        {
            if (other == null)
                return false;

            if (this.numeroRecogida == other.numeroRecogida)
                return true;
            else
                return false;
        }
    }
}
