using Microsoft.AspNetCore.Mvc;
using OnlineLibraryProject.Web.Models;

namespace OnlineLibraryProject.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                return View(model);
            }
            return View(model); 
        }


        public IActionResult Register()
        {
            return View();
        }

    }

}

