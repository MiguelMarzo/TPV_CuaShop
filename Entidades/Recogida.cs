using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Recogida : IEquatable<Recogida>
    {
        public int numeroRecogida;
        public DateTime fecha;
        public int cantidadArticulos;
        public string entregador;
        public int numeroEmpleado;

        public Recogida()
        {

        }

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
