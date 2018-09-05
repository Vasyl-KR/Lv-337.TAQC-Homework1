using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace UnitTestCalc
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            Calculator calc = new Calculator();
            int expected = 6;

            //Act
            int result = calc.Add(2, 4);

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}
