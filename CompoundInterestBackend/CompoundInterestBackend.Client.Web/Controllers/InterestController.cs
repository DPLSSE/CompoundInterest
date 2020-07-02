using CompoundInterestBackend.Common.Contracts;
using CompoundInterestBackend.Managers;
using CompoundInterestBackend.Managers.Shared;
using Microsoft.AspNetCore.Mvc;

namespace CompoundInterestBackend.Client.Web.Controllers
{
    public class InterestController : Controller
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
        
        public double CalculateInterest(double principle)
        {
            return CreateManager().CalculateInterest(principle);
        }
    }
}