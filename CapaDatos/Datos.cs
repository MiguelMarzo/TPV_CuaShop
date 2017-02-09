using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos.dsCuaShopTableAdapters;

namespace CapaDatos
{
    public class Datos
    {
        private dsCuaShop dsShop;
        private RecogidaTableAdapter daRecogida;
        private ArticuloTableAdapter daArticulo;
        private EmpleadoTableAdapter daEmpleado;
        private VentaTableAdapter daVenta;
        public Datos()
        {
            CrearDataSetCompleto();
        }

        public void CrearDataSetCompleto()
        {
            dsShop = new dsCuaShop();

            daArticulo = new dsCuaShopTableAdapters.ArticuloTableAdapter();
            daArticulo.Fill(dsShop.Articulo);

            daEmpleado = new dsCuaShopTableAdapters.EmpleadoTableAdapter();
            daEmpleado.Fill(dsShop.Empleado);

            daRecogida = new dsCuaShopTableAdapters.RecogidaTableAdapter();
            daRecogida.Fill(dsShop.Recogida);

            daVenta = new dsCuaShopTableAdapters.VentaTableAdapter();
            daVenta.Fill(dsShop.Venta);
        }

        public List<Articulo> DevolverTodosLosArticulos()
        {
            var articulos = from daArticulos in dsShop.Articulo
                            orderby daArticulos.descripcion ascending
                            select new Articulo(daArticulos.codigoArticulo, daArticulos.descripcion, daArticulos.tallaPesoLitros,
                            daArticulos.stock, daArticulos.fechaCaducidad, daArticulos.numeroRecogida, daArticulos.numeroPedido,
                            daArticulos.numeroVenta, daArticulos.precio, daArticulos.idiva);
            
            return articulos.ToList();
        }
        
        public String CrearRegistroRecogida(String entregador, short numeroArticulosEntregados, short numeroEmpleado)
        {
            dsCuaShop.RecogidaRow drRegistroRecogida = dsShop.Recogida.NewRecogidaRow();
            drRegistroRecogida.fecha = DateTime.Today;
            drRegistroRecogida.cantidadArticulos = numeroArticulosEntregados;
            drRegistroRecogida.entregador = entregador;
            drRegistroRecogida.numeroEmpleado = numeroEmpleado;
            drRegistroRecogida.numeroRecogida = maxRecogida();
            dsShop.Recogida.AddRecogidaRow(drRegistroRecogida);
            daRecogida.Update(drRegistroRecogida);
            return "Insertado";
            //try
            //{

            //}catch
            //{
            //    return "Error";
            //}
            
        }

        public List<Empleado> devolverEmpleados()
        {
            var empleados = from daEmpleado in dsShop.Empleado
                            orderby daEmpleado.nombreEmpleado
                            select new Empleado(daEmpleado.numeroEmpleado, daEmpleado.rutaFoto, daEmpleado.nombreEmpleado);

            return empleados.ToList();

        }

        public int maxRecogida()
        {
            var numRecogida = dsShop.Recogida.OrderByDescending(x => x.numeroRecogida).First().numeroRecogida;
            
            return numRecogida + 1;
        }

        public string existeArticulo(string codigoArticulo)
        {

            var articulo = from art in dsShop.Articulo
                           where art.codigoArticulo.Equals(codigoArticulo)
                           select new Articulo();

            if (articulo == null) {
                return "No existe";
            }else
            {
                return "Existe";
            }
            
        }

        public string insertarArticulo(string codigoArticulo, string descripcion, string tallaPesoLitros, int stock,
            DateTime fechaCaducidad, int numeroRecogida, int numeroPedido, decimal precio)
        {
            var iva = 1; //CORREGIR, AÑADIR METODO PARA CALCULAR EL IVA E INSERTARLO AQUI
            Articulo art = new Articulo(codigoArticulo, descripcion, tallaPesoLitros, stock, fechaCaducidad, numeroRecogida, numeroPedido, 0, precio, iva);

            try
            {
                dsCuaShop.ArticuloRow drArticulo = dsShop.Articulo.NewArticuloRow();
                drArticulo.codigoArticulo = art.codigoArticulo;
                drArticulo.descripcion = art.descripcion;
                drArticulo.tallaPesoLitros = art.tallaPesoLitros;
                drArticulo.stock = short.Parse(art.stock.ToString());
                drArticulo.fechaCaducidad = art.fechaCaducidad;
                drArticulo.numeroRecogida = art.numeroRecogida;
                drArticulo.numeroPedido = art.numeroPedido;
                drArticulo.numeroVenta = short.Parse(art.numeroVenta.ToString());
                drArticulo.precio = art.precio;
                drArticulo.idiva = art.iva;
                dsShop.Articulo.AddArticuloRow(drArticulo);
                daArticulo.Update(drArticulo);
                return "Insertado";
            }
            catch
            {
                return "Error";
            }

    }

        public string actualizarStockArticulo(string codigoArticulo, short cantidad) {

            try
            {
                var drArticulo = dsShop.Articulo.FindBycodigoArticulo(codigoArticulo);
                drArticulo.stock += cantidad;
                daArticulo.Update(drArticulo);
                return "Actualizado";
            }catch (Exception ex)
            {
                return "No se ha podido actualizar: " + ex.Message;
            }
            

        }

        public List<Articulo> devolverVenta(string codigoVenta)
        {
            var articulos = from daArticulo in dsShop.Articulo
                            orderby daArticulo.numeroVenta.ToString().Equals(codigoVenta)
                            select new Articulo(daArticulo.codigoArticulo, daArticulo.descripcion, daArticulo.tallaPesoLitros, daArticulo.stock, daArticulo.fechaCaducidad,
                            daArticulo.numeroRecogida, daArticulo.numeroPedido, daArticulo.numeroVenta, daArticulo.precio, daArticulo.idiva);

            return articulos.ToList();
        }

        public string actualizarPrecioVenta(int codigoVenta, int precio)
        {
            try
            {
                var drVenta = dsShop.Venta.FindBynumeroVenta((short) codigoVenta);
                drVenta.precioVenta -= precio;
                daVenta.Update(drVenta);
                return "Actualizado";
            }
            catch (Exception ex)
            {
                return "No se ha podido actualizar: " + ex.Message;
            }
        }

    }
}
