using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test;

namespace UnitTestProject1
{
    [TestClass]
    public class Calculator
    {
        [TestMethod]
        public void Multiply()
        {
            //Arrange
            Calculator calc = new Calculator();
            int expected = 6;

            //Act
            int result = calc.Multiply(2,4);

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
