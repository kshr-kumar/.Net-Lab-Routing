using Lab_Routing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks.Dataflow;

namespace Lab_Routing.Controllers
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
            if(model.UserName == "user@gmail.com" &&  model.Password == "12345678")
            {
                return RedirectToAction("Index", "Home", new { area = "user" });
            }
            else if(model.UserName == "admin@gmail.com" && model.Password == "12345678")
            {
                return RedirectToAction("Index", "Home", new {area = "Admin"});
            }
               
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }


    }
}
