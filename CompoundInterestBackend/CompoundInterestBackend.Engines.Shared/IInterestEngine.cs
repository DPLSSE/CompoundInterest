namespace CompoundInterestBackend.Engines.Shared
{
    public interface IInterestEngine
    {
        double CalculateCompoundedInterest(double principal, double interestRate, int timesPerYear, double years);
    }
}