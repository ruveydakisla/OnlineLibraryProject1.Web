using BussinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace OnlineLibraryProject.Web.Controllers
{
    public class UserController : Controller
    {
        private Context _context;
        BookManager bm = new BookManager(new EfBookRepository());
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult BookShow(int id)
        {
            var book = bm.GetById(id);
            return View(book);
        }

        
    }
}
