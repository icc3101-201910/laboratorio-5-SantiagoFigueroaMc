using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class PerroFactorial : ICalcular
    {
        public int Calcular(int numero)
        {
            int fact = 1;
            while (numero > 0)
            {
                fact *= numero;
                numero--;
            }
            return fact;
        }
    }
}
