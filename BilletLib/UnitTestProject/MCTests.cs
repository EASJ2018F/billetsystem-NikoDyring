using System;
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
            double discountedPris = 0;
            if (suzuki.WeekendRabat)
            {
                discountedPris = suzuki.Pris();
            }
            else if (!suzuki.WeekendRabat)
            {
                pris = suzuki.Pris();
            }
            
            // Assert
            if (suzuki.WeekendRabat)
            {
                Assert.AreEqual(100, discountedPris);
            }
            else
            {
                Assert.AreEqual(125, pris);
            }
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
            Assert.AreEqual(119, mc5.Pris());
        }

        [TestMethod]
        public void McØresundTest()
        {
            // Arrange
            MC mc8 = new MC();
            // Act
            mc8.Øresundsbroen = true;
            // Assert
            Assert.AreEqual(210, mc8.Pris());
        }

        [TestMethod]
        public void McBrobizzØresundTest()
        {
            // Arrange
            MC mc9 = new MC();
            // Act
            mc9.Øresundsbroen = true;
            mc9.BrobizzBrugt = true;
            // Assert
            Assert.AreEqual(73, mc9.Pris());
        }

        [TestMethod]
        public void McTypeAfKøretøjØresundTest()
        {
            // Arrange
            MC mc10 = new MC();
            // Act
            mc10.Øresundsbroen = true;
            // Assert
            Assert.AreEqual("Øresund MC", mc10.TypeAfKøretøj());
        }

    }
}
