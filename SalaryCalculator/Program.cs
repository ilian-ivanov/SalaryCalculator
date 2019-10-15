using System;

namespace SalaryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write the gross salary: ");

            if (decimal.TryParse(Console.ReadLine(), out decimal grossSalary))
            {
                var netSalary = Calculator.CalculateNetSalary(grossSalary);
                Console.WriteLine($"The net salary is: {netSalary}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
