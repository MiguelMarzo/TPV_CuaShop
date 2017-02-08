using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public class Datos
    {
        private dsCuaShop dsShop;
        private dsCuaShopTableAdapters.RecogidaTableAdapter daRecogida;
        public Datos()
        {
            CrearDataSetCompleto();
        }

        public void CrearDataSetCompleto()
        {
            dsShop = new dsCuaShop();

            var daArticulo = new dsCuaShopTableAdapters.ArticuloTableAdapter();
            daArticulo.Fill(dsShop.Articulo);

            var daEmpleado = new dsCuaShopTableAdapters.EmpleadoTableAdapter();
            daEmpleado.Fill(dsShop.Empleado);

            daRecogida = new dsCuaShopTableAdapters.RecogidaTableAdapter();
            daRecogida.Fill(dsShop.Recogida);

            var daVenta = new dsCuaShopTableAdapters.VentaTableAdapter();
            daVenta.Fill(dsShop.Venta);
        }

        public List<Articulo> DevolverTodosLosArticulos()
        {
            var articulos = from daArticulos in dsShop.Articulo
                            orderby daArticulos.descripcion ascending
                            select new Articulo(daArticulos.codigoArticulo, daArticulos.descripcion, daArticulos.tallaPesoLitros,
                            daArticulos.stock, daArticulos.fechaCaducidad, daArticulos.numeroRecogida, daArticulos.numeroPedido,
                            daArticulos.numeroVenta, daArticulos.precio);
            
            return articulos.ToList();
        }
        public String CrearRegistroRecogida(String entregador, short numeroArticulosEntregados, short numeroEmpleado)
        {
            dsCuaShop.RecogidaRow drRegistroRecogida = dsShop.Recogida.NewRecogidaRow();
            drRegistroRecogida.fecha = DateTime.Today;
            drRegistroRecogida.cantidadArticulos = numeroArticulosEntregados;
            drRegistroRecogida.entregador = entregador;
            drRegistroRecogida.numeroEmpleado = numeroEmpleado;
            dsShop.Recogida.AddRecogidaRow(drRegistroRecogida);
            daRecogida.Update(drRegistroRecogida);
            return null;
        }


    }
}
