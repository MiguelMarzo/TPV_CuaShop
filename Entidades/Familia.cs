﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Familia : IEquatable<Familia>
    {
        public String idFamilia;
        public String rutaFoto;
        public String nombreFamilia;
        public String incialesFamilia;

        public Familia()
        {

        }

        public Familia(String idFamilia, String rutaFoto, String nombreFamilia, String inicialesFamilia)
        {
            this.idFamilia = idFamilia;
            this.rutaFoto = rutaFoto;
            this.nombreFamilia = nombreFamilia;
            this.incialesFamilia = inicialesFamilia;
        }

        public bool Equals(Familia other)
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
            return nombreFamilia.ToString();
        }
    }
}

