﻿using System;
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

        public string insertarArticulo(string codigoArticulo, string descripcion, string tallaPesoLitros, int cantidad,
            DateTime fechaCaducidad, int numeroRecogida, int numeroPedido, int numeroVenta, decimal precio, string familia, string subfamilia)
        {
            return _datos.insertarArticulo(codigoArticulo, descripcion, tallaPesoLitros, cantidad,
                fechaCaducidad, numeroRecogida, numeroPedido,numeroVenta, precio, familia, subfamilia);
        }


        public List<Articulo> devolverVenta(string codigoVenta)
        {
            return _datos.devolverVenta(codigoVenta);
        }

        public string actualizarPrecioVenta(int codigoVenta, int precio)
        {
            return _datos.actualizarPrecioVenta(codigoVenta, precio);
        }
        public List<Familia> devolverFamilias()
        {
            return _datos.devolverFamilias();
        }
    }
}
