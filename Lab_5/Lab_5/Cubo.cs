using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Cubo : ICalcular
    {
        public int Calcular(int numero)
        {
            int cubo = 1;
            for (int i = 0; i < 3; i++)
            {
                cubo *= numero;
            }
            return cubo;
        }
    }
}
