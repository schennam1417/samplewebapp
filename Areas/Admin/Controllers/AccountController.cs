using Microsoft.AspNetCore.Mvc;

namespace samplewebapp.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }

       
    }
}
