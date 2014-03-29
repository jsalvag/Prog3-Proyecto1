using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog3_Proyecto1
{
    public class C_CLIENTES : IEquatable<C_CLIENTES>
    {
        private string
            ci,
            nom,
            ape,
            dir,
            telf;

        public List<C_CLIENTES> listaClientes = new List<C_CLIENTES>();

        public C_CLIENTES(string ci, string nom, string ape, string dir, string telf)
        {
            this.ci = ci;
            this.nom = nom;
            this.ape = ape;
            this.dir = dir;
            this.telf = telf;
        }

        public bool Equals(C_CLIENTES other)
        {
            if (this.ci == other.ci)
                return true;
            else
                return false;
        }

        public string verDatos()
        {
            return "Cedula: " + this.ci + "\tNombre: " + this.ape + ", " + this.nom + "\tTeléfono: " + this.telf + "\tDireccón: " + this.dir;
        }

        public string[] datos()
        {
            string[] data = new string[5];
            data[0] = this.ci;
            data[1] = this.nom;
            data[2] = this.ape;
            data[3] = this.dir;
            data[4] = this.telf;
            return data;
        }
    }
}
