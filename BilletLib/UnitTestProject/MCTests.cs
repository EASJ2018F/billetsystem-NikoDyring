﻿using System;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void McPrisEr125Test()
        {
            // Arrange
            MC suzuki = new MC();
            // Act
            double pris = suzuki.Pris();
            // Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod]
        public void McKøretøjTypeTest()
        {
            // Arrange
            MC honda = new MC();
            // Act
            string typeAfKøretøj = honda.TypeAfKøretøj();
            // Assert
            Assert.AreEqual("MC", typeAfKøretøj);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void McNummerpladeLængdeTest()
        {
            // Arrange
            MC mc3 = new MC();
            // Act
            mc3.Nummerplade = "12345678";
            // Assert
            Assert.AreEqual(8, mc3.LængdeAfNummerplade());
        }

        [TestMethod]
        public void McNummerpladeTest()
        {
            // Arrange
            MC mc4 = new MC();
            // Act
            mc4.Nummerplade = "12345";
            // Assert
            Assert.AreEqual(5, mc4.LængdeAfNummerplade());
        }

        [TestMethod]
        public void McBrobizzBrugtTest()
        {
            // Arrange
            MC mc5 = new MC();
            // Act
            mc5.BrobizzBrugt = true;
            // Assert
            Assert.AreEqual(131, mc5.Pris());
        }
    }
}
