using ExercicioInterrup.Entities;
using ExercicioInterrup.Entities.Exeptions;
using System;
using System.Globalization;

namespace ExercicioInterrup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter scconut data");

            try {
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Holder: ");
                string holder = (Console.ReadLine());

                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Widraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, 0.0, withdrawLimit);

                account.Deposit(initialBalance);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

                account.Withdraw(withdraw);

                Console.WriteLine("New Balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }

        }
    }
}