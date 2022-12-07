using Microsoft.AspNetCore.Mvc;
using OnlineLibraryProject.Web.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using OnlineLibraryProject.Web.Entities;
//using AuthProject.Models;

namespace OnlineLibraryProject.Web.Controllers
{
    public class AccountController : Controller
    {

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (model.UserName == "user" &&
                 model.Password == "123456"
                 )
            {
                List<Claim> claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier, model.UserName),
                    new Claim("OtherProperties","Example Role")

                };

                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {

                    AllowRefresh = true,
                    IsPersistent = model.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);

                return RedirectToAction("Index", "Home");

            }
            ViewData["ValidateMessage"] = "user not found";
            return View();
        }
        public IActionResult Login() {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");


            return View();
        }


        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction(nameof(Login));
            }
            return View(model);
        }

        public IActionResult Register() 
        {
            return View();
        }
        public IActionResult Profile()
        {
           

            return View();
        }

        

            public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }


    }

}

