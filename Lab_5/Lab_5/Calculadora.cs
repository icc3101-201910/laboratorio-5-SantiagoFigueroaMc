using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Calculadora
    {
        private Random random = new Random();
        private int numero;

        public List<ICalcular> calculadoras;

        public int GetNumero()
        {
            return numero;
        }

        public void Calcular()
        {
            numero = calculadoras[random.Next(0, calculadoras.Count())].Calcular(numero);
        }
    }
}
