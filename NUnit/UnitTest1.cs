using System;
using NUnit.Framework;
using Homework1;

namespace NUnitTest
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void AddTest()
        {
            Calculator calc = new Calculator();
            int expectedResult = calc.Add(7, 8);
            Assert.That(expectedResult, Is.EqualTo(15));
        }

        [Test]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            int expectedResult = calc.Multiply(7, 8);
            Assert.That(expectedResult, Is.EqualTo(56));
        }

        [Test]
        public void SubstractTest()
        {
            Calculator calc = new Calculator();
            int expectedResult = calc.Subtract(7, 8);
            Assert.That(expectedResult, Is.EqualTo(-1));
        }

        [Test]
        public void DivisionTest()
        {
            Calculator calc = new Calculator();
            float expectedResult = calc.Division(7, 8);
            Assert.That(expectedResult, Is.EqualTo((double)7/8));
        }
    }
}
