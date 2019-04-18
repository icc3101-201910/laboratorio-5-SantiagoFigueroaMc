using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Calculadora
    {
        private int numero= 0;

        public List<ICalcular> calculadoras;

        public Calculadora()
        {
            calculadoras = new List<ICalcular>();
            calculadoras.Add(new PerroFactorial());
            calculadoras.Add(new Cubo());
            calculadoras.Add(new Cuadrado());
            calculadoras.Add(new RobotFibonacci());
            calculadoras.Add(new PersonaQueSuma5());
        }

        public int GetNumero()
        {
            return numero;
        }

        public void SetNumero(int n)
        {
            numero = n;
        }

        public void Calcular(int tipo_operacion)
        {
            numero = calculadoras[tipo_operacion].Calcular(numero);
        }
    }
}
