using System;
using System.Globalization;

namespace ContaBancariaExercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int numConta;
            double saldo;
            double depositoInicial;
            double saque;
            char resposta;
            
            ContaBancaria usuario;

            Console.Write("Entre com o titular da conta: "); //variaveis temporais para maior segurança
            nome = Console.ReadLine();

            Console.Write("Entre com o número da conta: ");
            numConta = int.Parse(Console.ReadLine());

            Console.Write("Haverá depósito inicial (s/n)? ");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                usuario = new ContaBancaria(nome, numConta, saldo);
            }
            else
            {
                usuario = new ContaBancaria(nome, numConta);
            }

            Console.WriteLine();
            Console.WriteLine("Dado da conta: ");
            Console.WriteLine(usuario.ToString());
            Console.WriteLine();

            Console.Write("Entre com um valor para deposito: ");
            depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            usuario.Deposito(depositoInicial);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(usuario.ToString());
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            usuario.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(usuario.ToString());

        }
    }
}
