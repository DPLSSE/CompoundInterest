using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompoundInterestBackend.Engines.Shared;

namespace CompoundInterestBackend.Tests.EngineTests
{
    [TestClass]
    public class DTOMapperTests
    {
        [TestMethod]
        [TestCategory("Engine Tests")]
        public void DTOMapper_IsDTOMApperConfigValid()
        {
            DTOMapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
