using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalTask;
using System.Collections.Generic;

namespace MSTest
{
    [TestClass]
    public class MS_FruitTest
    {
        [TestMethod]
        public void InputNameTest()
        {
            //Arrange
            string testLine = "Apple red";
            Fruit expected = new Fruit("Apple", "red");
            Fruit actual = new Fruit();

            //Act
            actual.Input(testLine);

            //Assert
            Assert.AreEqual(expected.Name, actual.Name, "Fruits name not equal");
            Assert.AreEqual(expected.Color, actual.Color, "Fruits color not equal");
        }

        [TestMethod]
        public void InputColorTest()
        {
            //Arrange
            string testLine = "Apple red";
            Fruit expected = new Fruit("Apple", "red");
            Fruit actual = new Fruit();

            //Act
            actual.Input(testLine);

            //Assert
            Assert.AreEqual(expected.Color, actual.Color, "Fruits color not equal");
        }

        [TestMethod]
        public void ToStringTest()
        {
            //Arrange
            string expected = "Fruit name - Apple, color - red";
            string actual;
            Fruit testFruit = new Fruit("Apple", "red");

            //Act
            actual = testFruit.ToString();

            //Assert
            Assert.AreEqual(expected, actual, "Invalid method ToString");
        }

        [TestMethod]
        public void SortTest()
        {
            //Arrange
            List<Fruit> expected = new List<Fruit>();
            expected.Add(new Fruit("Apple", "red"));
            expected.Add(new Citrus("Orange", "orange", 10));
            expected.Add(new Fruit("Watermelon", "yellow"));

            List<Fruit> actual = new List<Fruit>();
            actual.Add(new Fruit("Watermelon", "yellow"));
            actual.Add(new Fruit("Apple", "red"));
            actual.Add(new Citrus("Orange", "orange", 10));

            //Act
            actual.Sort();

            //Assert
            Assert.AreEqual(expected[0].Name, actual[0].Name, "Incorrect sorting");
        }

    }
}
