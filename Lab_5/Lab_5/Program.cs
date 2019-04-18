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
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("Ingrese un numero:");
                int n = random.Next(1,1000);
                try
                {
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Input invalido, se usara un valor aleatorio entre 1 y 1000.");
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("Ese es un numero muy grande, solo Int32. Usando valor aleatorio entre 1 y 1000");
                }
                    
                
                if (n < 0)
                {
                    break;
                }
                Console.WriteLine($"Numero recibido: {n}\n");

                Console.WriteLine("Seleccionar operacion:\n" +
                    " 1. Perro factorial.\n" +
                    " 2. Cubo\n" +
                    " 3. Cuadrado\n" +
                    " 4. Robot fibonacci\n" +
                    " 5. Persona que suma 5");

                int calculo = random.Next(1, 6);
                try
                {
                    calculo = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("Opcion invalida, usando una opcion aleatoria de las anteriores");
                }

                if (1 <= calculo && calculo <= 5)
                {
                    if (n > 46 && calculo == 4)
                    {
                        Console.WriteLine("Fibonacci de 46 es el ultimo que cabe en la variable int. Usando n = 46");
                        n = 46;
                    }
                    if (n > 13 && calculo == 1)
                    {
                        Console.WriteLine("Factorial de 13 es el ultimo que cabe en la variable int. Usando n = 13");
                        n = 46;
                    }
                    calculo--;
                    calculadora.SetNumero(n);
                    calculadora.Calcular(calculo);
                    n = calculadora.GetNumero();
                    Console.WriteLine($"\nNumero calculado: {n}\n");
                }
                else
                    Console.WriteLine("Opcion invalida");
            }
        }
    }
}
