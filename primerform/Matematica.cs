using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerForm
{
    internal interface IMatematica
    {
        int Sumar(int a, int b);
        int Restar(int a, int b);
        int Multiplicar(int a, int b);
        double Dividir(int a, int b);  // Usar double para mayor precisión
        int Modulo(int a, int b);
    }
}
