using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArticulosVenta : IEquatable<ArticulosVenta>
    {
        public String codigoArticulo { get; set; }
        public short numeroVenta { get; set; }

        public ArticulosVenta(String codigoArticulo, short numeroVenta)
        {
            this.codigoArticulo = codigoArticulo;
            this.numeroVenta = numeroVenta;
        }

        public bool Equals(ArticulosVenta other)
        {
            if (other == null)
                return false;

            if (this.codigoArticulo == other.codigoArticulo && this.numeroVenta == other.numeroVenta)
                return true;
            else
                return false;
        }
    }
}
