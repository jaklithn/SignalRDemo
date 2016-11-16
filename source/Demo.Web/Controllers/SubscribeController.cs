using System.Linq;
using System.Web.Mvc;
using Demo.Web.Models;
using Demo.Web.Services;

namespace Demo.Web.Controllers
{
    public class SubscribeController : Controller
    {
		[Authorize]
        public ActionResult Index()
        {
            var userId = User.Identity.Name;
            var subscribedmachines = SubscriptionService.GetSubscribedMachines(userId);
            var machines = new MachineRepository().GetMachines().ToDictionary(x => x, x => subscribedmachines.Contains(x.Id));
            var model = new MachinesModel {Machines = machines};
            return View(model);
        }

		[Authorize]
		public void SetSubscription(int machineId, bool isSubscribed)
        {
            var userId = User.Identity.Name;
            SubscriptionService.SetSubscription(userId, machineId, isSubscribed);
        }
    }
}