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
            double discountedPris = 0;
            if (opel.WeekendRabat)
            {
                discountedPris = opel.Pris();
            }
            else if (!opel.WeekendRabat)
            {
                pris = opel.Pris();
            }

            // Assert
            if (opel.WeekendRabat)
            {
                Assert.AreEqual(192, discountedPris);
            }
            else
            {
                Assert.AreEqual(240, pris);
            }

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

            if (bil5.WeekendRabat)
            {
                Assert.AreEqual(180, bil5.Pris());
            }

            if (!bil5.WeekendRabat) 
            {
                Assert.AreEqual(228, bil5.Pris());
            }


        }

        [TestMethod]
        public void BilWeekendRabatTest()
        {
            // Arrange
            Bil bil6 = new Bil();
            // Act
            bil6.WeekendRabat = true;
            // Assert
            Assert.AreEqual(192, bil6.WeekendRabatIBil());
        }

        [TestMethod]
        public void BilWeekendPlusBrobizzRabat()
        {
            // Arrange
            Bil bil7 = new Bil();
            // Act
            bil7.Dato = DayOfWeek.Saturday;
            bil7.BrobizzBrugt = true;
            
            // Assert
            Assert.AreEqual(183, bil7.WeekendRabatIBil());
        }

        [TestMethod]
        public void BilØresundTest()
        {
            // Arrange
            Bil bil8 = new Bil();
            // Act
            bil8.Øresundsbroen = true;
            // Assert
            Assert.AreEqual(410, bil8.Pris());
        }

        [TestMethod]
        public void BilBrobizzØresundTest()
        {
            // Arrange
            Bil bil9 = new Bil();
            // Act
            bil9.Øresundsbroen = true;
            bil9.BrobizzBrugt = true;
            // Assert
            Assert.AreEqual(161, bil9.Pris());
        }

        [TestMethod]
        public void BilTypeAfKøretøjØresundTest()
        {
            // Arrange
            Bil bil10 = new Bil();
            // Act
            bil10.Øresundsbroen = true;
            // Assert
            Assert.AreEqual("Øresund Bil", bil10.TypeAfKøretøj());
        }

        [TestMethod]
        public void BilWeekendRabatSaturdayTest()
        {
            // Arrange
            Bil bil11 = new Bil();
            // Act
            bil11.Dato = DayOfWeek.Saturday;
            // Assert
            Assert.AreEqual(192, bil11.WeekendRabatIBil());
        }

        [TestMethod]
        public void BilWeekendRabatSundayTest()
        {
            Bil sundayBil = new Bil();
            sundayBil.Dato = DayOfWeek.Sunday;
            Assert.AreEqual(192, sundayBil.WeekendRabatIBil());
        }

        [TestMethod]
        public void BilWeekendRabatFalse()
        {
            Bil testBil = new Bil();
            testBil.WeekendRabat = false;
            Assert.AreEqual(240, testBil.WeekendRabatIBil());
        }


        [TestMethod]
        public void BilWeekendRabatBrobissTest()
        {
            Bil bil12 = new Bil();

            bil12.Dato = DayOfWeek.Saturday;
            bil12.BrobizzBrugt = true;
            bil12.WeekendRabat = true;

            Assert.AreEqual(183, bil12.WeekendRabatIBil());
        }
    }
}
