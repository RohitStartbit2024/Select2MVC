using Microsoft.AspNetCore.Mvc;
using Select2MVC.Models;

namespace Select2MVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            // If already logged in, go to Top
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("UserName")))
                return RedirectToAction("Index", "Top");

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "Enter required fields.";
                return View(model);
            }

            // Dummy credential check
            if (model.LoginId == "admin01" && model.Password == "admin@1234")
            {
                HttpContext.Session.SetString("UserName", model.LoginId);
                return RedirectToAction("Index", "Top");
            }

            ViewBag.Error = "Invalid username or password.";
            return View(model);
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
