using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void MCPrisEr125Test()
        {
            // Arrange
            MC suzuki = new MC();
            // Act
            int pris = suzuki.Pris();
            // Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void MCKøretøjTypeTest()
        {
            // Arrange
            MC honda = new MC();
            // Act
            string typeAfKøretøj = honda.TypeAfKøretøj();
            // Assert
            Assert.AreEqual("MC", typeAfKøretøj);
        }
    }
}
