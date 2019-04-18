using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Cuadrado : ICalcular
    {
        public int Calcular(int numero)
        {
            int cuadrado = 1;
            for (int i = 0; i < 2; i++)
            {
                cuadrado *= numero;
            }
            return cuadrado;
        }
    }
}
