using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerform
{
    internal class Informacion
    {
        public string nombre;
        public int edad;
        public int cedula;
        public string direccion;
        public string comentario;

        public Informacion(string nombre, int edad, int cedula, string direccion, string comentario)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.cedula = cedula;
            this.direccion = direccion;
            this.comentario = comentario;
        }




    }
}
