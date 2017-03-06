using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos.dsCuaShopTableAdapters;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Datos
    {
        private dsCuaShop dsShop;
        private RecogidaTableAdapter daRecogida;
        private ArticuloTableAdapter daArticulo;
        private EmpleadoTableAdapter daEmpleado;
        private VentaTableAdapter daVenta;
        private FamilliaTableAdapter daFamilia;
        private SubFamiliaTableAdapter daSubFamilia;
        private AdminTableAdapter daAdmin;
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

            daFamilia = new dsCuaShopTableAdapters.FamilliaTableAdapter();
            daFamilia.Fill(dsShop.Famillia);

            daSubFamilia = new dsCuaShopTableAdapters.SubFamiliaTableAdapter();
            daSubFamilia.Fill(dsShop.SubFamilia);

            daAdmin = new dsCuaShopTableAdapters.AdminTableAdapter();
            daAdmin.Fill(dsShop.Admin);
        }

        //METODOS PARA DEVOLVER OBJETOS (SELECTS)
        public List<Articulo> DevolverTodosLosArticulos()
        {
            var articulos = from drArticulo in dsShop.Articulo
                            orderby drArticulo.descripcion ascending
                            select new Articulo(drArticulo.codigoArticulo, drArticulo.descripcion, drArticulo.tallaPesoLitros, drArticulo.stock,
                            drArticulo.numeroRecogida, drArticulo.numeroPedido, drArticulo.numeroVenta, drArticulo.precio, drArticulo.localizacion,
                            drArticulo.idFamilia, drArticulo.idSubFamilia);

            return articulos.ToList();
        }
        public List<Empleado> DevolverEmpleados()
        {
            var empleados = from drEmpleado in dsShop.Empleado
                            orderby drEmpleado.nombreEmpleado
                            select new Empleado(drEmpleado.numeroEmpleado, drEmpleado.rutaFoto, drEmpleado.nombreEmpleado);

            return empleados.ToList();
        }
        public List<Familia> DevolverFamilias()
        {
            var familias = from drFamilia in dsShop.Famillia
                           select new Familia(drFamilia.idFamilia, drFamilia.rutaFoto, drFamilia.nombreFamilia, drFamilia.inicialesFamilia);
            return familias.ToList();
        }
        public List<SubFamilia> DevolverSubFamilias(Familia fam)
        {
            var subFamilias = from drSubFam in dsShop.SubFamilia
                              where drSubFam.idFamilia == fam.idFamilia
                              select new SubFamilia(drSubFam.idSubFamilia, drSubFam.idFamilia, drSubFam.nombreSubFamilia, drSubFam.idIva,
                              drSubFam.inicialesSubFamilia);
            return subFamilias.ToList();
        }
        public List<Recogida> DevolverRecogidas()
        {
            var recogidas = from drRecogida in dsShop.Recogida
                            select new Recogida(drRecogida.numeroRecogida, drRecogida.fecha, drRecogida.cantidadArticulos,
                            drRecogida.entregador, drRecogida.numeroEmpleado);
            return recogidas.ToList();
        }
        public List<Articulo> DevolverArticulosPorSubFamilia(SubFamilia subFam)
        {
            var articulos = from drArt in dsShop.Articulo
                            where drArt.idSubFamilia == subFam.idSubFamilia
                            select new Articulo(drArt.codigoArticulo, drArt.descripcion, drArt.tallaPesoLitros, drArt.stock,
                            drArt.numeroRecogida, drArt.numeroPedido, drArt.numeroVenta, drArt.precio, drArt.localizacion,
                            drArt.idFamilia, drArt.idSubFamilia);
            return articulos.ToList();
        }
        public Articulo DevolverArticuloPorCodigo(String codigo)
        {
            var articulo = from drArt in dsShop.Articulo
                           where drArt.codigoArticulo == codigo
                           select new Articulo(drArt.codigoArticulo, drArt.descripcion, drArt.tallaPesoLitros, drArt.stock,
                           drArt.numeroRecogida, drArt.numeroPedido, drArt.numeroVenta, drArt.precio, drArt.localizacion,
                           drArt.idFamilia, drArt.idSubFamilia);
            return articulo.ToList()[0];
        }
        public List<Admin> DevolverAdmins()
        {
            var admins = from daAdmin in dsShop.Admin
                         select new Admin(daAdmin.Id, daAdmin.Usuario, daAdmin.Contraseña);
            return admins.ToList();
        }

        public List<Articulo> DevolverArticulosLikeCodigo(String codigo)
        {
            var arts = from drArt in dsShop.Articulo
                       where drArt.codigoArticulo.Contains(codigo)
                       select new Articulo(drArt.codigoArticulo, drArt.descripcion, drArt.tallaPesoLitros, drArt.stock,
                            drArt.numeroRecogida, drArt.numeroPedido, drArt.numeroVenta, drArt.precio, drArt.localizacion,
                            drArt.idFamilia, drArt.idSubFamilia);
            return arts.ToList();
        }

        //FIN METODOS DEVOLVER OBJETOS (SELECTS)


        //METODOS CREAR REGISTRO Y AUXILIARES (INSERTS)
        public String CrearRegistroRecogida(String entregador, short numeroArticulosEntregados, short numeroEmpleado)
        {
            dsCuaShop.RecogidaRow drRegistroRecogida = dsShop.Recogida.NewRecogidaRow();
            drRegistroRecogida.fecha = DateTime.Today;
            drRegistroRecogida.cantidadArticulos = numeroArticulosEntregados;
            drRegistroRecogida.entregador = entregador;
            drRegistroRecogida.numeroEmpleado = numeroEmpleado;
            drRegistroRecogida.numeroRecogida = MaxRecogida();
            dsShop.Recogida.AddRecogidaRow(drRegistroRecogida);
            daRecogida.Update(drRegistroRecogida);
            return "Insertado";
        }
        public int MaxRecogida()
        {
            var numRecogida = dsShop.Recogida.OrderByDescending(x => x.numeroRecogida).First().numeroRecogida;

            return numRecogida + 1;
        }
        public String RegistroNuevoArticulo(string codigoArticulo, string descripcion, string tallaPesoLitros, int stock,
            int numeroRecogida, int numeroPedido, int numeroVenta, decimal precio, String localizacion, Familia familia, SubFamilia subfamilia)
        {
            var articulo = dsShop.Articulo.FindBycodigoArticulo(codigoArticulo);

            Articulo art = new Articulo(codigoArticulo, descripcion, tallaPesoLitros, stock, numeroRecogida,
            numeroPedido, numeroVenta, precio, localizacion, familia.idFamilia, subfamilia.idSubFamilia);
            if (articulo == null)
            {
                dsCuaShop.ArticuloRow drArticulo = dsShop.Articulo.NewArticuloRow();
                drArticulo.codigoArticulo = art.codigoArticulo;
                drArticulo.descripcion = art.descripcion;
                drArticulo.tallaPesoLitros = art.tallaPesoLitros;
                drArticulo.numeroRecogida = art.numeroRecogida;
                drArticulo.numeroPedido = art.numeroPedido;
                drArticulo.numeroVenta = 0;
                drArticulo.precio = art.precio;
                drArticulo.stock = (short) art.stock;
                drArticulo.localizacion = art.localizacion;
                drArticulo.idFamilia = art.idFamilia;
                drArticulo.idSubFamilia = art.idSubFamilia;
                drArticulo.idiva = subfamilia.idIva;
                dsShop.Articulo.AddArticuloRow(drArticulo);
                daArticulo.Update(drArticulo);
                return "Insertado";
            }
            else
            {
                ActualizarStockArticulo(art.codigoArticulo, art.stock);
                return "Actualizado stock";
            }
        }
        public bool ExisteArticulo(string codigoArticulo)
        {
            var articulo = dsShop.Articulo.FindBycodigoArticulo(codigoArticulo);
            if (articulo == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public String InsertarEmpleado(String nombre, String rutaFoto)
        {
            dsCuaShop.EmpleadoRow drEmpleado = dsShop.Empleado.NewEmpleadoRow();
            drEmpleado.numeroEmpleado = (short) MaxEmpleado();
            drEmpleado.nombreEmpleado = nombre;
            drEmpleado.rutaFoto = rutaFoto;
            dsShop.Empleado.AddEmpleadoRow(drEmpleado);
            daEmpleado.Update(drEmpleado);
            return "Insertado";
        }
        private int MaxEmpleado()
        {
            var numEmpleado = dsShop.Empleado.OrderByDescending(x => x.numeroEmpleado).First().numeroEmpleado;

            return numEmpleado + 1;
        }

        public String EfectuarVenta(List<Articulo> articulosVenta, Empleado empleado)
        {
            Decimal precioTotal = 0;
            try
            {
                foreach (Articulo art in articulosVenta)
                {
                    var drArticulo = dsShop.Articulo.FindBycodigoArticulo(art.codigoArticulo);
                    drArticulo.stock -= (short)art.stock;
                    drArticulo.numeroVenta = (short) maxNumeroVenta();
                    precioTotal += art.precio * art.stock;
                    dsShop.Articulo.GetChanges();
                    drArticulo.AcceptChanges();
                }
            }
            catch
            {
                return "Error actualizando stock articulos";
            }
            dsCuaShop.VentaRow drVenta = dsShop.Venta.NewVentaRow();
            drVenta.numeroVenta = (short)maxNumeroVenta();
            drVenta.numeroEmpleado = (short) empleado.numeroEmpleado;
            drVenta.precioVenta = precioTotal;
            drVenta.fechaVenta = DateTime.Today.Date;
            dsShop.Venta.AddVentaRow(drVenta);
            daVenta.Update(drVenta);
            return "Venta insertada y stocks actualizados";
        }

        private int maxNumeroVenta()
        {
            var numVenta = dsShop.Venta.OrderByDescending(x => x.numeroVenta).First().numeroVenta;
            return numVenta + 1;
        }
        //FIN METODOS CREAR REGISTRO (INSERTS)


        //METODOS PARA ACTUALIZAR DATOS (UPDATES)
        public String DevolverArticulo(string codigoArticulo)
        {
            try
            {
                var drArticulo = dsShop.Articulo.FindBycodigoArticulo(codigoArticulo);
                drArticulo.numeroVenta = 0;
                daArticulo.Update(drArticulo);
                dsShop.Articulo.GetChanges();
                drArticulo.AcceptChanges();
                return "Articulo devulelto correctamente";
            } catch
            {
                return "Fallo en la devolución";
            }

        }
        public String ActualizarStockArticulo(String codigo, int cantidad)
        {
            try
            {
                var drArticulo = dsShop.Articulo.FindBycodigoArticulo(codigo);
                drArticulo.stock += (short)cantidad;
                daArticulo.Update(drArticulo);
                dsShop.Articulo.GetChanges();
                drArticulo.AcceptChanges();
                return "Stock actualizado correctamente";
            } catch
            {
                return "Error actualizando el stock!";
            }
        }
        public string ActualizarPrecioVenta(int codigoVenta, int precio)
        {
            try
            {
                var drVenta = dsShop.Venta.FindBynumeroVenta((short)codigoVenta);
                drVenta.precioVenta -= precio;
                daVenta.Update(drVenta);
                dsShop.Venta.GetChanges();
                drVenta.AcceptChanges();
                return "Actualizado";
            }
            catch (Exception ex)
            {
                return "No se ha podido actualizar: " + ex.Message;
            }
        }


        //FIN METODOS PARA ACUALIZAR DATOS (UPDATES)    

        //OTROS METODOS
        public bool AdminLogin(String usuario, String contraseña)
        {
            var admins = from daAdmin in dsShop.Admin
                         select new Admin(daAdmin.Id, daAdmin.Usuario, daAdmin.Contraseña);
            foreach (Admin admin in admins.ToList())
            {
                if (admin.usuario == usuario && admin.contraseña == contraseña)
                {
                    return true;
                }
                    
            }
            return false;
        }

        public Admin ComprobarAdminUsuario(String usuario)
        {
            foreach (Admin admin in DevolverAdmins())
            {
                if (admin.usuario.ToUpper() == usuario.ToUpper())
                {
                    return admin;
                } 
            }
            return null;
        }
    }
}
