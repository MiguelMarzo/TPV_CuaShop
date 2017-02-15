using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Iva
    {
        public int idIva;
        public String tipo;

        public Iva(int idIva, String tipo)
        {
            this.idIva = idIva;
            this.tipo = tipo;
        }
    }
}
