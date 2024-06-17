using FixacaoVetor;
using System;
using System.Numerics;

namespace FixacaoVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, email;
            int num;

            CadRooms[] vect = new CadRooms[10];

            Console.Write("How Many rooms will be rented? ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < x; i++)
            {
                Console.WriteLine();
                Console.Write($"Rent #{i+1}: ");
                Console.WriteLine();

                Console.Write("Name: ");
                name= Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Room: ");
                num = int.Parse(Console.ReadLine());

                vect[num] = new CadRooms(name, email);

             }

            Console.WriteLine();
            Console.Write("Busy rooms: ");

            for (int i = 0; i<10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i] + ": " + vect[i]); //vect é objeto
                }

            }
            
        }
    }
}