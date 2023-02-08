using Microsoft.AspNetCore.Mvc;
using StaycationDemo.Models;
using StaycationDemo.Services;
using StaycationDemo.ViewModels;

namespace StaycationDemo.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserServices _userServices;
        public AuthController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _userServices.Login(model);
                if (user != null)
                {
                    //HttpContext.Session.SetString("Fullname", $"{user.FirstName} {user.LastName}");
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool registered = _userServices.Register(model);
                if (registered)
                {
                    return RedirectToAction("Login");
                }
            }
            return View();
        }
    }
}
