using System;

namespace FibonacciApp
{
    public class Fibonacci
    {
        public int GetNumberIndex(int index)
        {
            if(index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            double phi = (1 + Math.Sqrt(5)) / 2;
            double phiPrime = -(1 / phi);

            double value = (1 / Math.Sqrt(5)) * (Math.Pow(phi, index) - Math.Pow(phiPrime, index));
            return (int)value;
        }
    }
}
