using System.Linq;
using System.Web.Mvc;
using Demo.Web.Models;
using Demo.Web.Services;


namespace Demo.Web.Controllers
{
	public class PublishController : Controller
	{
		[Authorize]
		public ActionResult Index()
		{
			var machines = new MachineRepository().GetMachines();
			var selectedMachineId = machines.Any() ? machines.First().Id : 0;
			var model = new AdminModel { Machines = machines, SelectedMachineId = selectedMachineId };
			return View(model);
		}
	}
}