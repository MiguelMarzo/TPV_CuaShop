using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaPresentacion
{
    static class StaticGlobal
    {
        private static Empleado _globalEmpleado = new Empleado();

        public static Empleado GlobalVar
        {
            get { return _globalEmpleado; }
            set { _globalEmpleado = value; }
        }
    }
}
