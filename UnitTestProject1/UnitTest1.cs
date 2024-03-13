using ConsoleAppIMC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Profil profil = new Profil("Jérôme", "Dubromelle", 80, 180);
            var resultatAttendu = 24.69;
            //Act
            var resultatTest = profil.calculIMC();
            //Assert
            Assert.AreEqual(resultatAttendu, profil.calculIMC(), delta: 0.1);
        }
    }
}
