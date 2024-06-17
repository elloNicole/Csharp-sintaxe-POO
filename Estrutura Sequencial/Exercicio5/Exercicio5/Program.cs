using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para ler o código da uma peça 1, o numero de paça 1, o valor unitario de cada peça 1 e o mesmo para a peça 2 e mostra o valor a ser pago

            string[] vetPiece1 = Console.ReadLine().Split(' ');
            int codPiece1 = int.Parse(vetPiece1[0]);
            int numPiece1 = int.Parse(vetPiece1[1]);
            double valPiece1 = double.Parse(vetPiece1[2], CultureInfo.InvariantCulture);

            string[] vetPiece2 = Console.ReadLine().Split(' ');
            int codPiece2 = int.Parse(vetPiece2[0]);
            int numPiece2 = int.Parse(vetPiece2[1]);
            double valPiece2 = double.Parse(vetPiece2[2], CultureInfo.InvariantCulture);

            double valueToPay = (numPiece1 * valPiece1) + (numPiece2 * valPiece2);

            Console.WriteLine($"VALOR A PAGAR = U$ {valueToPay.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}