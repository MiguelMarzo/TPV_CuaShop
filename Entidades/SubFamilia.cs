using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class SubFamilia : IEquatable<SubFamilia>
    {
        public String idSubFamilia;
        public String idFamilia;
        public String nombre;

        public SubFamilia()
        {

        }

        public SubFamilia(String idSubFamilia, String idFamilia, String nombre)
        {
            this.idSubFamilia = idSubFamilia;
            this.idFamilia = idFamilia;
            this.nombre = nombre;
        }

        public bool Equals(SubFamilia other)
        {
            if (other == null)
                return false;

            if (this.idFamilia == other.idFamilia)
                return true;
            else
                return false;
        }
    }
}
