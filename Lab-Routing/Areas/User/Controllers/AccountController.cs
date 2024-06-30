using Microsoft.AspNetCore.Mvc;

namespace Lab_Routing.Areas.User.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
