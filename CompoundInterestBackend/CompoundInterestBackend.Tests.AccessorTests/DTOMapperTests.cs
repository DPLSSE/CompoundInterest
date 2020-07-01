using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompoundInterestBackend.Accessors.Shared;

namespace CompoundInterestBackend.Tests.AccessorTests
{
    [TestClass]
    public class DTOMapperTests
    {
        [TestMethod]
        [TestCategory("Accessor Tests")]
        public void DTOMapper_IsDTOMapperConfigValid()
        {
            DTOMapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
