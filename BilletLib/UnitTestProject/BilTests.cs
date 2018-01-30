using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class BilTests
    {
        [TestMethod]
        public void BilPris240Test()
        {
            // Arrange
            Bil Opel = new Bil();
            // Act
            int pris = Opel.Pris();
            // Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod]
        public void BilKøretøjTest()
        {
            // Arrange
            Bil Toyota = new Bil();
            // Act
            string køretøj = Toyota.Køretøj();
            // Assert
            Assert.AreEqual("Bil", køretøj);
        }
    }
}
