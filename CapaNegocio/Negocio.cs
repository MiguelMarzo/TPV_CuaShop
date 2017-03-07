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

        public List<Empleado> DevolverEmpleados()
        {
            return _datos.DevolverEmpleados();
        }

        public int MaxRecogida()
        {
            return _datos.MaxRecogida();
        }

        public bool ExisteArticulo(string codigoArticulo)
        {
            return _datos.ExisteArticulo(codigoArticulo);
        }

        public string RegistroNuevoArticulo(string codigoArticulo, string descripcion, string tallaPesoLitros, int cantidad,
            int numeroRecogida, int numeroPedido, int numeroVenta, decimal precio, String localizacion, Familia familia, SubFamilia subfamilia)
        {
            return _datos.RegistroNuevoArticulo(codigoArticulo, descripcion, tallaPesoLitros, cantidad,
                numeroRecogida, numeroPedido, numeroVenta, precio, localizacion, familia, subfamilia);
        }

        public List<Recogida> DevolverRecogidas()
        {
            return _datos.DevolverRecogidas();
        }

        public String DevolverArticulo(string codigoArticulo)
        {
            return _datos.DevolverArticulo(codigoArticulo);
        }

        public string ActualizarPrecioVenta(int codigoVenta, int precio)
        {
            return _datos.ActualizarPrecioVenta(codigoVenta, precio);
        }

        public List<Familia> DevolverFamilias()
        {
            return _datos.DevolverFamilias();
        }

        public List<SubFamilia> DevolverSubFamiliasPorFamilia(Familia fam)
        {
            return _datos.DevolverSubFamilias(fam);
        }

        public List<Articulo> DevolverArticulosPorSubFamilia(SubFamilia subFam)
        {
            return _datos.DevolverArticulosPorSubFamilia(subFam);
        }

        public Articulo DevolverArticuloPorCodigo(String codigo)
        {
            return _datos.DevolverArticuloPorCodigo(codigo);
        }

        public String ActualizarStockArticulo(String codigo, int cantidad)
        {
            return _datos.ActualizarStockArticulo(codigo, cantidad);
        }

        public String InsertarEmpleado(String nombre, String rutaFoto)
        {
            return _datos.InsertarEmpleado(nombre, rutaFoto);
        }
        public bool AdminLogin(String usuario, String contraseña)
        {
            return _datos.AdminLogin(usuario, contraseña);
        }
        public Admin ComprobarAdminUsuario(String usuario)
        {
            return _datos.ComprobarAdminUsuario(usuario);
        }

        public String EfectuarVenta(List<Articulo> articulosVenta, Empleado empleado)
        {
            return _datos.EfectuarVenta(articulosVenta, empleado);
        }

        public List<Articulo> DevolverArticulosLikeCodigo(String codigo)
        {
            return _datos.DevolverArticulosLikeCodigo(codigo);
        }

        public List<Articulo> BuscarArticuloEspecifico(string descripcion, Familia familia, SubFamilia subFamilia, int numeroRecogida, int numeroPedido, int numeroVenta, Iva iva, int estanteria, int estante, int altura)
        {
            return _datos.BuscarArticuloEspecifico(descripcion, familia, subFamilia, numeroRecogida, numeroPedido, numeroVenta, iva, estanteria, estante, altura);
        }

        public List<Iva> DevolverIvas()
        {
            return _datos.DevolverIvas();
        }

        //public bool ArticuloVendido()
        //{

        //}
    }
}
