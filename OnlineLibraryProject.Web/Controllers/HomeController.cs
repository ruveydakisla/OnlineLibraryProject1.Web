using BookLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineLibraryProject.Web.Models;
using System.Diagnostics;

namespace OnlineLibraryProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookDataContext context;

        public HomeController(BookDataContext context)
        {
            this.context = context;
this.context = context;
        }

        public IActionResult Index()
        {
            var Books=this.context.Books.Include("Writers").ToList();
            return View(Books);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}