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
            Bil opel = new Bil();
            // Act
            int pris = opel.Pris();
            // Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod]
        public void BilKøretøjTypeTest()
        {
            // Arrange
            Bil toyota = new Bil();
            // Act
            string typeAfKøretøj = toyota.TypeAfKøretøj();
            // Assert
            Assert.AreEqual("Bil", typeAfKøretøj);
        }
    }
}
