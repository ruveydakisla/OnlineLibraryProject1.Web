using Microsoft.AspNetCore.Mvc;
using OnlineLibraryProject.Web.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using OnlineLibraryProject.Web.Entities;
using NETCore.Encrypt.Extensions;
//using AuthProject.Models;

namespace OnlineLibraryProject.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _Context;
        private readonly IConfiguration _configuration;
        public AccountController(AppDbContext dataBaseContext, IConfiguration configuration)
        {
            this._Context = dataBaseContext;
            this._configuration = configuration;
        }

        [HttpPost]
        public  async Task<IActionResult> Login(LoginViewModel model)
        {
            
            if (ModelState.IsValid )
            {

                Users user = _Context.Users.SingleOrDefault(x => x.UserName.ToLower() == model.UserName.ToLower() && x.Password == EncryptWithMD5(model.Password));

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
            if (_Context.Users.Any(x => x.UserName.ToLower() == model.UserName.ToLower()))
            {
                ModelState.AddModelError(nameof(model.UserName), "Username is already exist.");
                return View(model);

            }

            if (ModelState.IsValid)
            {
                Users user = new()
                {
                    Password = EncryptWithMD5(model.Password),
                    UserName = model.UserName,
                    Address= model.Address,
                    NameSurname=model.NameSurname
                };
                _Context.Users.Add(user);

                _Context.SaveChanges();
               
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

        public string EncryptWithMD5(string password)
        {
            string md5salt = "911892D7";
            string saltedPassword = md5salt + password;
            string hashedPassword = saltedPassword.MD5();
            return hashedPassword;
        }

       


    }

}

