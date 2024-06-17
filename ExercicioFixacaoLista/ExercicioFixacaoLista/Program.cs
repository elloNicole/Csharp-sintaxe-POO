using ExercicioFixacaoLista;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace ExercicioFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("How many employees will be registered? ");
            int num= int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Employee #{i + 1}: ");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = (Console.ReadLine());

                Console.Write("Salary: ");
                double salary  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employe id that will have salary increse : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId); //a posição vai continuar a mesma somente ocorre uma mudança de salario com base no endereco que list estava apontando 

            if(emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentege = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentege); //recebeu o lugar da lista onde esta e modifica o salario com metodo 

            }
            else
            {
                Console.Write("This id does not exist! ");

            }

            Console.WriteLine();
            Console.Write("Update list of employees: ");
            foreach(Employee obj in list) //faz a listagem dos objetos onde estam na lista
            {
                Console.WriteLine(obj);
            }
        }
    }
}