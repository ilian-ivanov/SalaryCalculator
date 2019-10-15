
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator
{
    public static class Calculator
    {
        private static readonly decimal nonTaxableMinimum = 1000;
        private static readonly decimal incomeTaxPercent = 0.1m;
        private static readonly decimal socialContributionPercent = 0.15m;
        private static readonly decimal socialContributionUpperBorder = 3000;

        public static decimal CalculateNetSalary(decimal grossSalary)
        {
            if (grossSalary < 0) throw new ArgumentException("The salary cannot be negative!");
            if (grossSalary <= nonTaxableMinimum) return grossSalary;

            decimal incomeTax = (grossSalary - nonTaxableMinimum) * incomeTaxPercent;
            decimal socialContribution = 0;

            if(grossSalary > socialContributionUpperBorder)
            {
                socialContribution = (socialContributionUpperBorder - nonTaxableMinimum) * socialContributionPercent;
            }
            else
            {
                socialContribution = (grossSalary - nonTaxableMinimum) * socialContributionPercent;
            }

            return grossSalary - (incomeTax + socialContribution);
        }
    }
}
