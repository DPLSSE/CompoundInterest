using System;

namespace CompoundInterestBackend.Engines.Shared
{
    public class InterestEngine : EngineBase, IInterestEngine
    {
        // Source: https://www.dotnetperls.com/compound-interest
        public double CalculateCompoundedInterest(double principal, double interestRate, int timesPerYear, double years)
        {
            // (1 + r/n)
            double body = 1 + (interestRate / timesPerYear);

            // nt
            double exponent = timesPerYear * years;

            // P(1 + r/n)^nt
            return principal * Math.Pow(body, exponent);
        }
    }
}