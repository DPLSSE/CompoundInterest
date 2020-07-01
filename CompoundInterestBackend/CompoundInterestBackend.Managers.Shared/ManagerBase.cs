using CompoundInterestBackend.Accessors;
using CompoundInterestBackend.Common.Shared;
using CompoundInterestBackend.Engines;
using CompoundInterestBackend.Utilities;

namespace CompoundInterestBackend.Managers.Shared
{
    public abstract class ManagerBase : ServiceContractBase
    {
        public EngineFactory EngineFactory { get; set; }
        public AccessorFactory AccessorFactory { get; set; }
        public UtilityFactory UtilityFactory { get; set; }

        protected ManagerBase()
        {

        }
    }
}
