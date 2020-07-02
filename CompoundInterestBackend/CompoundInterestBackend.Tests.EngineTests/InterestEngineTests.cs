using System;
using CompoundInterestBackend.Accessors;
using CompoundInterestBackend.Common.Contracts;
using CompoundInterestBackend.Engines;
using CompoundInterestBackend.Engines.Shared;
using CompoundInterestBackend.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CompoundInterestBackend.Tests.EngineTests
{
    [TestClass]
    public class InterestEngineTests
    {
        private EngineFactory CreateFactory()
        {
            var context = new AmbientContext();
            var utilityFactory = new UtilityFactory(context);
            var accessorFactory = new AccessorFactory(context, utilityFactory);
            
            var engineFactory = new EngineFactory(context, 
                accessorFactory, 
                utilityFactory);
            return engineFactory;
        }

        private IInterestEngine CreateEngine()
        {
            var engineFactory = CreateFactory();
            var engine = engineFactory.CreateEngine<IInterestEngine>();
            return engine;
        }
        
        [TestMethod]
        public void InterestEngine_CreateEngine_Test()
        {
            var engine = CreateEngine();
            Assert.IsNotNull(engine);
        }
        
        [TestMethod]
         public void InterestEngine_BasicCalculation_Test()
         {
             var engine = CreateEngine();
             var finalValue = 
                 engine.CalculateCompoundedInterest(1000, 0.1, 12, 4);
 
             Assert.IsTrue(finalValue > 0);
         }
    }
}