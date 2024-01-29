using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using samplewebapp.Models;

namespace samplewebapp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            
                if (model.username == "admin@gmail.com" && model.password == "12345678")
                {
                    return RedirectToAction("Profile", "Account", new { area = "admin" });
                }
                else if (model.username == "user@gmail.com" && model.password == "12345678")
                {
                    return RedirectToAction("Profile", "Account", new { area = "User" });
                }
                
                
            
            return View();
        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
