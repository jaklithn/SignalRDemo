using System.Web.Mvc;


namespace Demo.Web.Controllers
{
	public class BroadcastController : Controller
	{
		[Authorize]
		public ActionResult Index()
		{
			return View();
		}
	}
}