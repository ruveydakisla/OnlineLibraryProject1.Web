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
        public UserController(Context context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            //var values = um.GetAllUsers();
            //return View (values);
            var book = bm.GetAllBooks();
            return View(book);
        }
        [HttpGet]
        public IActionResult BookShow(int id)
        {
            var book = bm.GetById(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult BookShow(Book updateProduct, int productId, string type)
        {
            updateProduct.BookID= productId;
            return View(updateProduct);
        }


    }
}
