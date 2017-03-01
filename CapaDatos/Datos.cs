using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos.dsCuaShopTableAdapters;
using System.Data.OleDb;

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
        }

        //METODOS PARA DEVOLVER OBJETOS (SELECTS)
        public List<Articulo> DevolverTodosLosArticulos()
        {
            var articulos = from daArticulo in dsShop.Articulo
                            orderby daArticulo.descripcion ascending
                            select new Articulo(daArticulo.codigoArticulo, daArticulo.descripcion, daArticulo.tallaPesoLitros, daArticulo.stock,
                            daArticulo.numeroRecogida, daArticulo.numeroPedido, daArticulo.numeroVenta, daArticulo.precio, daArticulo.localizacion,
                            daArticulo.idFamilia, daArticulo.idSubFamilia);

            return articulos.ToList();
        }
        public List<Empleado> DevolverEmpleados()
        {
            var empleados = from daEmpleado in dsShop.Empleado
                            orderby daEmpleado.nombreEmpleado
                            select new Empleado(daEmpleado.numeroEmpleado, daEmpleado.rutaFoto, daEmpleado.nombreEmpleado);

            return empleados.ToList();
        }
        public List<Familia> DevolverFamilias()
        {
            var familias = from daFamilia in dsShop.Famillia
                           select new Familia(daFamilia.idFamilia, daFamilia.rutaFoto, daFamilia.nombreFamilia);
            return familias.ToList();
        }
        public List<SubFamilia> DevolverSubFamilias(Familia fam)
        {
            var subFamilias = from daSubFam in dsShop.SubFamilia
                              where daSubFam.idFamilia == fam.idFamilia
                              select new SubFamilia(daSubFam.idSubFamilia, daSubFam.idFamilia, daSubFam.nombreSubFamilia, daSubFam.idIva);
            return subFamilias.ToList();
        }
        public List<Recogida> DevolverRecogidas()
        {
            var recogidas = from daRecogida in dsShop.Recogida
                            select new Recogida(daRecogida.numeroRecogida, daRecogida.fecha, daRecogida.cantidadArticulos,
                            daRecogida.entregador, daRecogida.numeroEmpleado);
            return recogidas.ToList();
        }
        public List<Articulo> DevolverVentaPorCodigoVenta(string codigoVenta)
        {
            var articulos = from daArticulo in dsShop.Articulo
                            orderby daArticulo.numeroVenta.ToString().Equals(codigoVenta)
                            select new Articulo(daArticulo.codigoArticulo, daArticulo.descripcion, daArticulo.tallaPesoLitros, daArticulo.stock,
                            daArticulo.numeroRecogida, daArticulo.numeroPedido, daArticulo.numeroVenta, daArticulo.precio, daArticulo.localizacion,
                            daArticulo.idFamilia, daArticulo.idSubFamilia);

            return articulos.ToList();
        }
        public List<Articulo> DevolverArticulosPorSubFamilia(SubFamilia subFam)
        {
            var articulos = from daArticulo in dsShop.Articulo
                            where daArticulo.idSubFamilia == subFam.idSubFamilia
                            select new Articulo(daArticulo.codigoArticulo, daArticulo.descripcion, daArticulo.tallaPesoLitros, daArticulo.stock,
                            daArticulo.numeroRecogida, daArticulo.numeroPedido, daArticulo.numeroVenta, daArticulo.precio, daArticulo.localizacion,
                            daArticulo.idFamilia, daArticulo.idSubFamilia);
            return articulos.ToList();
        }
        public Articulo DevolverArticuloPorCodigo(String codigo)
        {

            var articulo = from daArticulo in dsShop.Articulo
                           where daArticulo.codigoArticulo == codigo
                           select new Articulo(daArticulo.codigoArticulo, daArticulo.descripcion, daArticulo.tallaPesoLitros, daArticulo.stock,
                           daArticulo.numeroRecogida, daArticulo.numeroPedido, daArticulo.numeroVenta, daArticulo.precio, daArticulo.localizacion,
                           daArticulo.idFamilia, daArticulo.idSubFamilia);
          
            return articulo.ToList()[0];
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


        //FIN METODOS CREAR REGISTRO (INSERTS)


        //METODOS PARA ACTUALIZAR DATOS (UPDATES)
        public String ActualizarStockArticulo(String codigo, int cantidad)
        {
            try
            {
                var drArticulo = dsShop.Articulo.FindBycodigoArticulo(codigo);
                drArticulo.stock += (short)cantidad;
                daArticulo.Update(drArticulo);
                dsShop.Articulo.GetChanges();
                drArticulo.AcceptChanges();
            } catch
            {
                return "Error actualizando el stock!";
            }
            return "";
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
        
        public List<Articulo> BuscarArticuloEspecifico(string descripcion, Familia familia, SubFamilia subFamilia, int numeroRecogida, int numeroPedido, int numeroVenta, Iva iva, int estanteria, int estante, int altura)
        {
            string cadCon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TPVdb1.accdb";

            List<Articulo> result = new List<Articulo>();

            string query = "";
            bool first = true;
            if(descripcion != "")
            {
                first = false;
                query += " descripcion = " + descripcion;
            }

            if(familia != null && subFamilia == null)
            {
                if(first)
                {
                    first = false;
                    query += " idFamilia = " + familia.idFamilia;
                }
                else
                {
                    query += " and idFamilia = " + familia.idFamilia;
                }
            }

            if(subFamilia != null)
            {
                if(first)
                {
                    first = false;
                    query += " idFamilia = " + subFamilia.idFamilia + " and idSubFamilia = " + subFamilia.idSubFamilia;
                }
                else
                {
                    query += " and idFamilia = " + subFamilia.idFamilia + " and idSubFamilia = " + subFamilia.idSubFamilia;
                }
            }

            if(numeroRecogida != -1)
            {
                if (first)
                {
                    first = false;
                    query += " numeroRecogida = " + numeroRecogida;
                }
                else
                {
                    query += " and numeroRecogida = " + numeroRecogida;
                }
            }

            if(numeroPedido != -1)
            {
                if (first)
                {
                    first = false;
                    query += " numeroPedido = " + numeroPedido;
                }
                else
                {
                    query += " and numeroPedido = " + numeroPedido;
                }
            }

            if(numeroVenta != -1)
            {
                if (first)
                {
                    first = false;
                    query += " numeroVenta = " + numeroVenta;
                }
                else
                {
                    query += " and numeroVenta = " + numeroVenta;
                }
            }

            if(iva != null)
            {
                if (first)
                {
                    first = false;
                    query += " idIva = " + iva.idIva;
                }
                else
                {
                    query += " and idIva = " + iva.idIva;
                }
            }

            if(estanteria != -1)
            {
                if(estante != -1)
                {
                    if(altura != -1)
                    {
                        if (first)
                        {
                            first = false;
                            query += " localizacion = " + estanteria + "." + estante + "." + altura;
                        }
                        else
                        {
                            query += " and localizacion = " + estanteria + "." + estante + "." + altura;
                        }
                    }
                    else
                    {
                        if (first)
                        {
                            first = false;
                            query += " localizacion like " + estanteria + "." + estante + ".%";
                        }else
                        {
                            query += " and localizacion like " + estanteria + "." + estante + ".%";
                        }
                    }
                }
                else if(altura != -1)
                {
                    if (first)
                    {
                        first = false;
                        query += " localizacion like " + estanteria + ".%." + altura;
                    }
                    else
                    {
                        query += " and localizacion like " + estanteria + ".%." + altura;
                    }
                }
                else
                {
                    if (first)
                    {
                        first = false;
                        query += " localizacion like " + estanteria + ".%.%";
                    }
                    else
                    {
                        query += " and localizacion like " + estanteria + ".%.%";
                    }
                }
                
            }
            else if(estante != -1)
            {
                if(altura != -1)
                {
                    if (first)
                    {
                        first = false;
                        query += " localizacion like %." + estante + "." + altura;
                    }
                    else
                    {
                        query += " and localizacion like %." + estante + "." + altura;
                    }
                }
                else
                {
                    if (first)
                    {
                        first = false;
                        query += " localizacion like %." + estante + ".%";
                    }
                    else
                    {
                        query += " and localizacion like %." + estante + ".%";
                    }
                }
            }
            else if(altura != -1)
            {
                if (first)
                {
                    first = false;
                    query += " localizacion like %.%." + altura;
                }
                else
                {
                    query += " and localizacion like %.%." + altura;
                }
            }

            string sql = "select * from Articulo where" + query;
            OleDbConnection conArticulo = new OleDbConnection(cadCon);
            OleDbCommand cmd = new OleDbCommand(sql, conArticulo);
            try
            {
                conArticulo.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                if(!dr.HasRows)
                {
                    return null;
                }

                while (dr.Read())
                {
                    result.Add(new Articulo((string)dr["codigoArticulo"], (string)dr["descripcion"], (string)dr["tallaPesoLitros"], (int)dr["stock"], (int)dr["numeroRecogida"], (int)dr["numeroPedido"], (int)dr["numeroventa"], (decimal)dr["precio"], (string)dr["localizacion"], (string)dr["idFamilia"], (string)dr["idSubFamilia"]));
                }
            }
            catch (Exception ex)
            {
                return null;
            }

            return result;
        }    
    }
}
