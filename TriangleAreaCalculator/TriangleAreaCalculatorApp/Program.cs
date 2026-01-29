using System;

namespace TriangleAreaCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Calculadora de Áreas ---");
                Console.WriteLine("1. Calcular Área de un Triángulo");
                Console.WriteLine("2. Calcular Área de un Cuadrado");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CalculateTriangleArea();
                        break;
                    case "2":
                        CalculateSquareArea();
                        break;
                    case "3":
                        Console.WriteLine("Saliendo de la calculadora. ¡Hasta luego!");
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, intente de nuevo.");
                        break;
                }

                Console.WriteLine("\nPresiona cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }

        static void CalculateTriangleArea()
        {
            Console.WriteLine("\n--- Cálculo de Área de Triángulo ---");

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
        }

        static void CalculateSquareArea()
        {
            Console.WriteLine("\n--- Cálculo de Área de Cuadrado ---");

            // Solicitar la longitud del lado del cuadrado
            double sideSquare;
            while (true)
            {
                Console.Write("Introduce la longitud del lado del cuadrado: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out sideSquare) && sideSquare > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, introduce un número positivo para el lado.");
                }
            }

            // Calcular el área
            double area = sideSquare * sideSquare;

            // Mostrar el resultado
            Console.WriteLine($"El área del cuadrado con lado {sideSquare} es: {area}");
        }
    }
}