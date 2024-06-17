using System;
using System.Globalization;

namespace Exercicio5 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, areaTriangle, areaCircle, areaTrapeze, areaSquare, areaRectangle;

            string[] numbers = Console.ReadLine().Split(' ');
            a = double.Parse(numbers[0], CultureInfo.InvariantCulture);
            b = double.Parse(numbers[1], CultureInfo.InvariantCulture);
            c = double.Parse(numbers[2], CultureInfo.InvariantCulture);

            areaTriangle = (a*c)/2;
            areaCircle = c * c * 3.14159;
            areaTrapeze = ((a + b) * c) / 2;
            areaSquare = b * b;
            areaRectangle = a * b;

            Console.WriteLine($"TRIANGULO: {areaTriangle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCircle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTrapeze.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaSquare.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRectangle.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}