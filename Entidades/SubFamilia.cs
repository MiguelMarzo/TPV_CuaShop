﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SubFamilia : IEquatable<SubFamilia>
    {
        public String idSubFamilia;
        public String idFamilia;
        public String nombre;
        public String inicialesSubFamilia;
        public int idIva;

        public SubFamilia()
        {

        }

        public SubFamilia(String idSubFamilia, String idFamilia, String nombre, int idIva, String inicialesSubFamilia)
        {
            this.idSubFamilia = idSubFamilia;
            this.idFamilia = idFamilia;
            this.nombre = nombre;
            this.idIva = idIva;
            this.inicialesSubFamilia = inicialesSubFamilia;
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

        public override string ToString()
        {
            return nombre.ToString();
        }
    }
}
