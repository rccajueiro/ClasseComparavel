using System;
using ClasseComparavel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClasseComparavelTest
{
    [TestClass]
    public class CompravelTest
    {
        [TestMethod]
        public void TestInstance()
        {
            new Comparavel();

            Equals(true);
        }

        [TestMethod]
        public void TestMaiorOuIgualTrue()
        {
            Assert.AreEqual(true, new Comparavel().MaiorOuIgual(5));
        }

        [TestMethod]
        public void TestMaiorOuIgualFalse()
        {
            Assert.AreEqual(false, new Comparavel().MaiorOuIgual(15));
        }

        [TestMethod]
        public void TestMenorOuIgualTrue()
        {
            Assert.AreEqual(true, new Comparavel().MenorOuIgual(15));
        }

        [TestMethod]
        public void TestMenorOuIgualFalse()
        {
            Assert.AreEqual(false, new Comparavel().MenorOuIgual(5));
        }

        [TestMethod]
        public void TestDiferenteDeTrue()
        {
            Assert.AreEqual(true, new Comparavel().DiferenteDe(15));
        }

        [TestMethod]
        public void TestDiferenteDeFalse()
        {
            Assert.AreEqual(false, new Comparavel().DiferenteDe(10));
        }
    }
}
