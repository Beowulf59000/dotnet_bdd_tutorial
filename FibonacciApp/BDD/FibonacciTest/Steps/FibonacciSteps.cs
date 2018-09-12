using FibonacciApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace FibonacciTest.Steps
{
    [Binding]
    public class FibonacciSteps
    {
        private int index;
        private int occurence;

        [Given(@"Je cherche l'occurence (.*)")]
        public void GivenJeChercheLOccurence(int index)
        {
            this.index = index;
        }

        [When(@"J'interroge la suite de Fibonacci")]
        public void WhenJInterrogeLaSuiteDeFibonacci()
        {
            Fibonacci fibonacci = new Fibonacci();
            this.occurence = fibonacci.GetNumberIndex(index);
        }

        [Then(@"Le résultat est (.*)")]
        public void ThenLeResultatEst(int expectedOccurence)
        {
            Assert.AreEqual(expectedOccurence, this.occurence);
        }
    }
}
