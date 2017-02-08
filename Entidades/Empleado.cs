using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : IEquatable<Empleado>
    {
        private int numeroEmpleado;
        private string rutaFoto;
        private string nombreEmpleado;

        public Empleado()
        {

        }

        public Empleado(int numeroEmpleado, string rutaFoto, string nombreEmpleado)
        {
            this.numeroEmpleado = numeroEmpleado;
            this.rutaFoto = rutaFoto;
            this.nombreEmpleado = nombreEmpleado;
        }

        public bool Equals(Empleado other)
        {
            if (other == null)
                return false;

            if (this.numeroEmpleado == other.numeroEmpleado)
                return true;
            else
                return false;
        }
    }
}
