using System;
using System.Globalization;

namespace ExercicioClasse3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno a1= new Aluno();
            
            Console.Write("Nome do aluno: ");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            a1.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //nn precis aatribuir valor a variavel
            Console.WriteLine("Nota Final = " + a1.CalculoNota().ToString("F2", CultureInfo.InvariantCulture));

            if (a1.Avaliacao())
            {
                Console.WriteLine("Aprovado! ");
            }
            else
            {
                Console.WriteLine("Reprovado! ");
                Console.WriteLine("Faltaram " + a1.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}