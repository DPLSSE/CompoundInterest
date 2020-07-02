using CompoundInterestBackend.Engines.Shared;

namespace CompoundInterestBackend.Managers.Shared
{
    public class InterestManager : ManagerBase, IInterestManager
    {
        public double CalculateInterest(double principle)
        {
            var engine = EngineFactory.CreateEngine<IInterestEngine>();
            return engine.CalculateCompoundedInterest(
                principle, 0.1, 12, 4);
        }
    }
}