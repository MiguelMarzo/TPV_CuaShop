using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class Negocio
    {
        private Datos _datos = new Datos();

        public List<Articulo> DevolverTodosLosArticulos() {
            return _datos.DevolverTodosLosArticulos();
        }
        public String CrearRegistroRecogida(String entregador, short numeroArticulosEntregados, short numeroEmpleado)
        {
            return _datos.CrearRegistroRecogida(entregador, numeroArticulosEntregados, numeroEmpleado);
        }
        public List<Empleado> devolverEmpleados()
        {
            return _datos.devolverEmpleados();
        }
        public int maxRecogida()
        {
            return _datos.maxRecogida();
        }
    }
}
