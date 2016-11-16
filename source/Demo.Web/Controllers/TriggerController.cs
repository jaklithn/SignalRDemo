using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using Demo.Web.Hubs;


namespace Demo.Web.Controllers
{
	public class TriggerController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public void Trigger()
		{
			var context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
			context.Clients.All.addNotification("I can trigger the notification from server side as well", "Server side", "success");
		}
	}
}