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
                try
                {
                    var netSalary = Calculator.CalculateNetSalary(grossSalary);
                    Console.WriteLine($"The net salary is: {netSalary}");
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
