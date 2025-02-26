using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primerform
{
    internal class Crud 
    {

        public List<Informacion> lista = new List<Informacion>();
        public void agregarObjeto(Informacion i)
        {
            lista.Add(i);
        }
    }
}
