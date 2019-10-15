using SalaryCalculator;
using System;
using Xunit;

namespace UnitTests
{
    public class CalculatorTests
    {
        [Fact]
        public void GrossSalary_UnderNonTaxableMinimum()
        {
            // Arrange
            decimal grossSalary = 980;
            decimal expectedSalary = 980;

            // Act
            decimal netSalary = Calculator.CalculateNetSalary(grossSalary);

            // Assert
            Assert.Equal(expectedSalary, netSalary);
        }

        [Fact]
        public void GrossSalary_EqualToNonTaxableMinimum()
        {
            // Arrange
            decimal grossSalary = 1000;
            decimal expectedSalary = 1000;

            // Act
            decimal netSalary = Calculator.CalculateNetSalary(grossSalary);

            // Assert
            Assert.Equal(expectedSalary, netSalary);
        }

        [Fact]
        public void GrossSalary_AboveNonTaxableMinimum_UnderSocialUpperBorder()
        {
            // Arrange
            decimal grossSalary = 2500;
            decimal expectedSalary = 2125;

            // Act
            decimal netSalary = Calculator.CalculateNetSalary(grossSalary);

            // Assert
            Assert.Equal(expectedSalary, netSalary);
        }

        [Fact]
        public void GrossSalary_EqualToSocialUpperBorder()
        {
            // Arrange
            decimal grossSalary = 3000;
            decimal expectedSalary = 2500;

            // Act
            decimal netSalary = Calculator.CalculateNetSalary(grossSalary);

            // Assert
            Assert.Equal(expectedSalary, netSalary);
        }

        [Fact]
        public void GrossSalary_AboveSocialUpperBorder()
        {
            // Arrange
            decimal grossSalary = 3400;
            decimal expectedSalary = 2860;

            // Act
            decimal netSalary = Calculator.CalculateNetSalary(grossSalary);

            // Assert
            Assert.Equal(expectedSalary, netSalary);
        }

        [Fact]
        public void GrossSalary_Negative_ThrowException()
        {
            // Arrange
            decimal grossSalary = -1;

            // Assert
            Assert.Throws<ArgumentException>(() => Calculator.CalculateNetSalary(grossSalary));
        }
    }
}
