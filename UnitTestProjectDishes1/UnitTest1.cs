using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectDishes1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string inputString = "kaft93x@outlook.com";

            // Act
            bool containsAtSymbol = ContainsAtSymbol(inputString);

            // Assert
            Assert.IsTrue(containsAtSymbol, "Строка должна содержать символ '@'.");
        }

        public bool ContainsAtSymbol(string input)
        {
            return input.Contains("com");
        }
    }
}
