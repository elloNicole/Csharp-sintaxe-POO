using System;
/*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
exemplo*/
namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool=0, gasolina=0, diesel=0, entrada;

            entrada = int.Parse(Console.ReadLine());

            while (entrada != 4)
            {
                if(entrada == 3)
                {
                    alcool ++;
                    
                }else if(entrada == 2)
                {
                    gasolina ++;

                } else if (entrada == 1)
                {
                    diesel ++;
                }

                entrada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}