using ExercicioHerancaPolimorfismo.Entities;
using System;
using System.Globalization;

namespace EercicioHerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i< num; i++)
            {
                Console.Write($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char tipe = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if ( tipe == 'c') //comum
                {
                    list.Add(new Product(name, price));
                }
                else if ( tipe == 'u') //UsedProduct
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else //Imported Product
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }


            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag()); //metodo adaptado p cada classe atraves do override e virtual
            }

        }
    }
}