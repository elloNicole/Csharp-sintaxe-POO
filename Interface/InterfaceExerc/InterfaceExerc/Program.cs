using InterfaceExerc.Entities;
using InterfaceExerc.Services;
using System.Globalization;

Console.WriteLine("Enter contract data");
Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
Console.Write("Concract Value: ");
double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract contract = new Contract(number, date, value);

ContractService contractService = new ContractService(new PaypalService());

contractService.ProcessContract(contract, months);

Console.WriteLine("Installments: ");

foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}


