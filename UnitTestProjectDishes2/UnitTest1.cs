using Dishes1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProjectDishes2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPasswordLength()
        {
            // Arrange
            MainWindow mainWindow = new MainWindow();

            // Act & Assert
            Assert.IsFalse(IsValidLength("gynQMT"));
            Assert.IsFalse(IsValidLength("AtnDjr"));
            Assert.IsFalse(IsValidLength("JlFRCZ"));
            Assert.IsFalse(IsValidLength("2L6KZG"));
            Assert.IsFalse(IsValidLength("uzWC67"));
            Assert.IsFalse(IsValidLength("8ntwUp"));
            Assert.IsFalse(IsValidLength("YOyhfR"));
            Assert.IsFalse(IsValidLength("RSbvHv"));
            Assert.IsFalse(IsValidLength("rwVDh9"));
            Assert.IsFalse(IsValidLength("LdNyos"));

        }

        private bool IsValidLength(string password)
        {
            return password.Length == 8;
        }
    }
}
