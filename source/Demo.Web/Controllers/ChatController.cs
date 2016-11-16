using System.Web.Mvc;
using Demo.Web.Models;
using Demo.Web.Services;


namespace Demo.Web.Controllers
{
    public class ChatController : Controller
    {
        public ActionResult Index()
        {
            var model = new AdminModel {Machines = new MachineRepository().GetMachines()};
            return View(model);
        }
    }
}