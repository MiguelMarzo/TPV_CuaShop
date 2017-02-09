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

        public List<Articulo> DevolverTodosLosArticulos()
        {
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

        public string existeArticulo(string codigoArticulo)
        {
            return _datos.existeArticulo(codigoArticulo);
        }

        public string insertarArticulo(string codigoArticulo, string descripcion, string tallaPesoLitros, int stock,
            DateTime fechaCaducidad, int numeroRecogida, int numeroPedido, decimal precio)
        {
            return _datos.insertarArticulo(codigoArticulo, descripcion, tallaPesoLitros, stock,
                fechaCaducidad, numeroRecogida, numeroPedido, precio);
        }

        public string actualizarStockArticulo(string codigoArticulo, short cantidad)
        {
            return _datos.actualizarStockArticulo(codigoArticulo, cantidad);
        }
    }
}
