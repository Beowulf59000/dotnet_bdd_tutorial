using FibonacciApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace FibonacciTest.Tests
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
    }
}
