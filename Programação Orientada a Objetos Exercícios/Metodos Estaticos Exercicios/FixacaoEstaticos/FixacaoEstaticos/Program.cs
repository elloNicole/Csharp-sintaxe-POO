using System.Globalization;
using System;

/*Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por
uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda
que a pessoa terá que pagar 6% de IOF sobre o valor em dólar. Criar uma classe ConversorDeMoeda
para ser responsável pelos cálculos*/


namespace FixacaoEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacao, dolaresComprados, valorPago;
            Console.WriteLine("Qual é a cotação do dólar?");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares você vai comprar?");
            dolaresComprados = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            valorPago = ConvertorDeMoedas.ValorPago(cotacao, dolaresComprados);

            Console.WriteLine("Valor a ser pago em reais: " + valorPago.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}