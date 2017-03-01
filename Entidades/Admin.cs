using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Admin :IEquatable<Admin>
    {
        public int id { get; set; }
        public String usuario { get; set; }
        public String contraseña { get; set; }

        public Admin(int id, String usuario, String pass)
        {
            this.id = id;
            this.usuario = usuario;
            this.contraseña = pass;
        }
        public bool Equals(Admin other)
        {
            if (other == null)
                return false;

            if (this.id == other.id)
                return true;
            else
                return false;
        }

    }
}
