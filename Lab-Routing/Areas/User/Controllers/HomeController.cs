using Microsoft.AspNetCore.Mvc;

namespace Lab_Routing.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
