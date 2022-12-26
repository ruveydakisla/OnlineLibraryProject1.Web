using Microsoft.AspNetCore.Mvc;
using OnlineLibraryProject.Web.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using NETCore.Encrypt.Extensions;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Concrete;
using System;

  
namespace OnlineLibraryProject.Web.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        UserManager um = new UserManager(new EfUserRepository());
        private readonly Context _context;

        public AccountController(Context dataBaseContext)
        {
            this._context = dataBaseContext;

        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            
            if (ModelState.IsValid)
            {
                string hashedPassword = EncryptWithMD5(model.Password);

                User user = _context.Users.SingleOrDefault(x => x.UserName.ToLower() == model.UserName.ToLower() && x.Password == hashedPassword);

                if (user != null)
                    { 
                    List<Claim> claims = new List<Claim>();
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()));
                    claims.Add(new Claim(ClaimTypes.Name, user.NameSurname ?? string.Empty));
                    claims.Add(new Claim(ClaimTypes.Role, user.Role));
                    claims.Add(new Claim("UserName", user.UserName));
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                    AuthenticationProperties properties = new AuthenticationProperties()
                    {

                        AllowRefresh = true,
                        IsPersistent = model.KeepLoggedIn
                    };
                    //await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, properties);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                   new ClaimsPrincipal(identity), properties);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is incorrect.");
                }
            }

            return View(model);
        }

        [AllowAnonymous]
        public IActionResult Login() {

            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");

            return View();


        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(RegisterViewModel model)
        {
            if (_context.Users.Any(x => x.UserName.ToLower() == model.UserName.ToLower()))
            {
                ModelState.AddModelError(nameof(model.UserName), "Username is already exist.");
                return View(model);
            }
            if (ModelState.IsValid)
            {
                User user = new()
                {
                    Password = EncryptWithMD5(model.Password),
                    UserName = model.UserName,
                    Address = model.Address,
                    NameSurname = model.NameSurname
                };
                um.UserAdd(user);

                _context.SaveChanges();
            }

            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [Authorize]
        public IActionResult Profile()
        {


            return View();
        }
        private void ProfileInfoLoader()
        {
            Guid userid = new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
            User user = _context.Users.SingleOrDefault(x => x.UserID == userid);

            ViewData["FullName"] = user.NameSurname;
        }

        [HttpPost]
        public IActionResult ProfileChangeFullName([Required][StringLength(50)] string? fullname)
        {
            if (ModelState.IsValid)
            {
                Guid userid = new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
                User user = _context.Users.SingleOrDefault(x => x.UserID == userid);

                user.NameSurname = fullname;
                _context.SaveChanges();

                return RedirectToAction(nameof(Profile));
            }

            ProfileInfoLoader();
            return View("Profile");
        }

        [HttpPost]
        public IActionResult ProfileChangePassword([Required][MinLength(6)][MaxLength(16)] string? password)
        {
            if (ModelState.IsValid)
            {
                Guid userid = new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
                User user = _context.Users.SingleOrDefault(x => x.UserID == userid);

                string hashedPassword = EncryptWithMD5(password);

                user.Password = hashedPassword;
                _context.SaveChanges();

                ViewData["result"] = "PasswordChanged";
            }

            ProfileInfoLoader();
            return View("Profile");
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

