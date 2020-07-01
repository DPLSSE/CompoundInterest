using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompoundInterestBackend.Managers.Shared;

namespace CompoundInterestBackend.Tests.ManagerTests
{
    [TestClass]
    public class DTOMapperTests
    {
        [TestMethod]
        [TestCategory("Manager Tests")]
        public void DTOMapper_IsDTOMApperConfigValid()
        {
            DTOMapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
