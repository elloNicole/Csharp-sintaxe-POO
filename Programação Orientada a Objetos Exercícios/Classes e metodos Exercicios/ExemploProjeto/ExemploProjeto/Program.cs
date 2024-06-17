using System;
using System.Globalization;

namespace ExemploProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser(em) adicionado(s) ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionaProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser(em) removido(s) ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoveProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados do produto: " + p); // retorna os metodos da classe

        }
    }
}