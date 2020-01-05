using System;
using NUnit.Framework;
using Calculator;

namespace CalculatorTests
{
    [TestFixture]
    public class Calculator
    {
    
        [TestCase(2, 3, 5)]
        [TestCase(5, 10, 15)]
        [TestCase(50, 100, 150)]
        [TestCase(5.1, 10.5, 15.6)]
        public void ShallAddDecimals(decimal a, decimal b, decimal c)
        {
            //Arrange
            decimal expected = c;
            //Act
            decimal actual = CalculatorUtils.Add(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, 6)]
        [TestCase(5, 10, 50)]
        [TestCase(50, 100, 5000)]
        [TestCase(5.1, 10.5, 53.55)]
        public void ShallMultiplyDecimals(decimal a, decimal b, decimal c)
        {
            //Arrange
            decimal expected = c;
            //Act
            decimal actual = CalculatorUtils.Multiplicate(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, -1)]
        [TestCase(5, 10, -5)]
        [TestCase(50, 100, -50)]
        [TestCase(5.1, 10.5, -5.4)]
        public void ShallSubstractDecimals(decimal a, decimal b, decimal c)
        {
            //Arrange
            decimal expected = c;
            //Act
            decimal actual = CalculatorUtils.Substract(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestCase(0, 3, 0)]
        [TestCase(5, 10, 0.5)]
        [TestCase(200, 100, 2)]
        [TestCase(5.12, 4, 1.28)]
        public void ShallDivideDecimals(decimal a, decimal b, decimal c)
        {
            //Arrange
            decimal expected = c;
            //Act
            decimal actual = CalculatorUtils.Divide(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3,0)]
        public void ShallThrowExceptionByZeroDivision(decimal a, decimal b)
        {
            //Arrange
         
            //Act & Assert

            Assert.Throws<ArgumentException>(() => CalculatorUtils.Divide(a, b));

        }
    }
}
