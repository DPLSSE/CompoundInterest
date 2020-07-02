using CompoundInterestBackend.Accessors;
using CompoundInterestBackend.Common.Contracts;
using CompoundInterestBackend.Engines;
using CompoundInterestBackend.Engines.Shared;
using CompoundInterestBackend.Managers;
using CompoundInterestBackend.Managers.Shared;
using CompoundInterestBackend.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompoundInterestBackend.Tests.ManagerTests
{
    [TestClass]
    public class InterestManagerTests : ManagerTestBase
    {
        private ManagerFactory CreateFactory()
        {
            var context = new AmbientContext();
            var managerFactory = new ManagerFactory(context);
            
            return managerFactory;
        }

        private IInterestManager CreateManager()
        {
            var managerFactory = CreateFactory();
            var manager = managerFactory.CreateManager<IInterestManager>();
            return manager;
        }
        
        [TestMethod]
        public void InterestManager_CalculateInterest_Test()
        {
            var manager = CreateManager();
            var finalValue = manager.CalculateInterest(1000);
            Assert.IsTrue(finalValue > 0);
        }
    }
}