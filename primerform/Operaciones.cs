using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimerForm;

namespace primerform
{
    internal class Operaciones : IMatematica
    {
        public double Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return (double)a / b; // Convertir a `double` antes de dividir
        }

        public int Modulo(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No se puede calcular el módulo con divisor cero.");
            }
            return a % b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
