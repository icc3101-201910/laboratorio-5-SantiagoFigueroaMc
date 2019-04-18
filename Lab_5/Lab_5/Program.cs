using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Ingrese un numero:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Numero recibido: {n}");
            Console.ReadLine();
        }
    }
}
