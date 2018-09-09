using System;
using NUnit.Framework;
using Test;

namespace NUnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Calculator calc = new Calculator();
            int result = 15;
            int expectedResult = calc.Add(7, 8);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
