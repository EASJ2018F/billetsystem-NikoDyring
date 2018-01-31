﻿using System;
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
            double pris = opel.Pris();
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

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BilNummerpladeLængdeTest()
        {
            // Arrange
            Bil bil3 = new Bil();
            // Act
            bil3.Nummerplade = "12345678";
            // Assert
            Assert.AreEqual(8, bil3.LængdeAfNummerplade());
        }

        [TestMethod]
        public void BilNummerpladeTest()
        {
            // Arrange
            Bil bil4 = new Bil();
            // Act
            bil4.Nummerplade = "12345";
            // Assert
            Assert.AreEqual(5, bil4.LængdeAfNummerplade());
        }

        [TestMethod]
        public void BilBrobizzBrugtTest()
        {
            // Arrange
            Bil bil5 = new Bil();
            // Act
            bil5.BrobizzBrugt = true;
            // Assert
            Assert.AreEqual(252,bil5.Pris());
        }


    }
}
