using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class RobotFibonacci : ICalcular
    {
        Dictionary<int, int> CalculatedFibonacci = new Dictionary<int, int>();
        public int Calcular(int numero)
        {
            return Fibonacci(numero);
        }

        private int Fibonacci(int n)
        {
            int value;
            if (n <= 1)
                return n;
            if (CalculatedFibonacci.TryGetValue(n, out value))
            {
                return value;
            }
            CalculatedFibonacci.Add(n, Fibonacci(n - 1) + Fibonacci(n - 2));
            return CalculatedFibonacci[n];
        }
    }
}
