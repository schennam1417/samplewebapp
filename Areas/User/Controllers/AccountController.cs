using Microsoft.AspNetCore.Mvc;

namespace samplewebapp.Areas.User.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }


    }
}
