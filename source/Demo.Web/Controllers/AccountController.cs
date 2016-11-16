using System.Web.Mvc;
using System.Web.Security;
using Demo.Web.Extenders;
using Demo.Web.Models;
using Demo.Web.Services;


namespace Demo.Web.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return Login();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Index");
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var userRepository = new UserRepository();
                var user = userRepository.GetUser(model.UserName, model.Password);
                if (user != null)
                {
                    AuthenticationHandler.SetAuthCookie(model.UserName.ToUpperFirst(), model.RememberMe, user.Roles);
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Login data is incorrect!");
            }
            return View("Index", model);
        }

        [HttpPost]
        public void RemoteLogin(string userName, string password)
        {
            var userRepository = new UserRepository();
            var user = userRepository.GetUser(userName, password);
            if (user != null)
            {
                AuthenticationHandler.SetAuthCookie(userName.ToUpperFirst(), false, user.Roles);
            }
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}