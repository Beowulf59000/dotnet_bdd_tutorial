using System;
using FibonacciApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciTest
{
    [TestClass]
    public class FibonacciTest
    {
        private Fibonacci fibonnaci;

        [TestInitialize]
        public void BeforeEachTest()
        {
            fibonnaci = new Fibonacci();
        }

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void ShouldThrowArgumentException_WhenIndexIsNotPositiveOrNull()
        {
            fibonnaci.GetNumberIndex(-2);
        }

        [TestMethod]
        public void ShouldReturnsZero()
        {
            int calculatedValue = fibonnaci.GetNumberIndex(0);
            Assert.AreEqual(0, calculatedValue);
        }

        [TestMethod]
        public void ShouldReturnsOne()
        {
            int calculatedValue = fibonnaci.GetNumberIndex(1);
            Assert.AreEqual(1, calculatedValue);
        }
    }
}
