
using System;
using System.Globalization;
using Mabs01.Entities;
using System.Collections.Generic;

namespace Mabs01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> list = new List<Taxpayer>();
            Console.WriteLine("How many taxpayers?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Indivual or Company (i/c) ? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {                    
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(health, name, income));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(employees, name, income));
                }
                                
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double totalTax = 0.0;
            foreach (Taxpayer taxpayer in list)
            {
                Console.WriteLine(taxpayer.Name + ": " + taxpayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTax += taxpayer.Tax();
            }
            Console.WriteLine("TOTAL TAXES: " + totalTax);

        }
    }
}
