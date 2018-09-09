using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;
//
namespace UnitTestCalc
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            Calculator calc1 = new Calculator();
            int expected = 6;

            //Act
            int result = calc1.Add(2, 4);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            //arrange
            double expected = 8;

            //act
            Calculator calc = new Calculator();
            double actual = calc.Multiply(2, 4);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SubtractTest()
        {
            //arrange
            double expected = -2;

            //act
            Calculator calc = new Calculator();
            double actual = calc.Subtract(2, 4);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DivisionTest()
        {
            //arrange
            double expected = 0.5;

            //act
            Calculator calc = new Calculator();
            double actual = calc.Division(2, 4);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}

