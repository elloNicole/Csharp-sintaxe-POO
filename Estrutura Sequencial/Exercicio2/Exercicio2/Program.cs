using System;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        private const string Format = "F4"; //Constante que define o formato de 4 casas decimais

        static void Main(string[] args)
        {
            Console.WriteLine("Esse programa lê o valor do raio de um circulo, e mostra a sua respectiva área");

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // armazena a entrada de valor double com ponto dentro de uma variavel double
            double area = 3.14 * raio * raio; // realiza o calculo da area multiplicando o valor de PI pelo quadrado do raio

            Console.WriteLine("A={0}", area.ToString(Format, CultureInfo.InvariantCulture));// mostra na tela a area no formato internacional com 4 casas decimais
 
        }
    }
}