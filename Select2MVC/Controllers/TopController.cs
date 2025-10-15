using Microsoft.AspNetCore.Mvc;

namespace Select2MVC.Controllers
{
    public class TopController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var user = HttpContext.Session.GetString("UserName");
            if (string.IsNullOrEmpty(user))
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.User = user;
            return View();
        }
    }
}
