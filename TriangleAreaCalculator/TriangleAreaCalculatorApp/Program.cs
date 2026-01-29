using System;

namespace TriangleAreaCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de Área de Triángulo");
            Console.WriteLine("--------------------------------");

            // Solicitar la base del triángulo
            double baseTriangle;
            while (true)
            {
                Console.Write("Introduce la longitud de la base del triángulo: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out baseTriangle) && baseTriangle > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, introduce un número positivo para la base.");
                }
            }

            // Solicitar la altura del triángulo
            double heightTriangle;
            while (true)
            {
                Console.Write("Introduce la altura del triángulo: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out heightTriangle) && heightTriangle > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, introduce un número positivo para la altura.");
                }
            }

            // Calcular el área
            double area = (baseTriangle * heightTriangle) / 2;

            // Mostrar el resultado
            Console.WriteLine($"El área del triángulo con base {baseTriangle} y altura {heightTriangle} es: {area}");

            Console.WriteLine("\nPresiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}