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
            new Comparavel(10);

            Equals(true);
        }

        [TestMethod]
        public void TestMaiorOuIgualTrue()
        {
            Assert.AreEqual(true, new Comparavel(10).MaiorOuIgual(5));
        }

        [TestMethod]
        public void TestMaiorOuIgualFalse()
        {
            Assert.AreEqual(false, new Comparavel(5).MaiorOuIgual(10));
        }

        [TestMethod]
        public void TestMenorOuIgualTrue()
        {
            Assert.AreEqual(true, new Comparavel(5).MenorOuIgual(10));
        }

        [TestMethod]
        public void TestMenorOuIgualFalse()
        {
            Assert.AreEqual(false, new Comparavel(10).MenorOuIgual(5));
        }

        [TestMethod]
        public void TestDiferenteDeTrue()
        {
            Assert.AreEqual(true, new Comparavel(5).DiferenteDe(10));
        }

        [TestMethod]
        public void TestDiferenteDeFalse()
        {
            Assert.AreEqual(false, new Comparavel(5).DiferenteDe(5));
        }
    }
}
