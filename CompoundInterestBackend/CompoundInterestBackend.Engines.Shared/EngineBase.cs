using CompoundInterestBackend.Accessors;
using CompoundInterestBackend.Common.Shared;
using CompoundInterestBackend.Utilities;

namespace CompoundInterestBackend.Engines.Shared
{
    public abstract class EngineBase : ServiceContractBase
    {
        public AccessorFactory AccessorFactory { get; set; }
        public UtilityFactory UtilityFactory { get; set; }

        protected EngineBase()
        {

        }
    }
}
