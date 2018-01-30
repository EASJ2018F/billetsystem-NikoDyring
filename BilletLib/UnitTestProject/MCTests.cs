using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void MCPrisEr125()
        {
            // Arrange
            MC Suzuki = new MC();
            // Act
            int pris = Suzuki.Pris();
            // Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void MCKøretøjTest()
        {
            // Arrange
            MC Honda = new MC();
            // Act
            string køretøj = Honda.Køretøj();
            // Assert
            Assert.AreEqual("MC", køretøj);
        }
    }
}
