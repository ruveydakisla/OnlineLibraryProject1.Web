using Microsoft.AspNetCore.Mvc;

using OnlineLibraryProject.Web.Models;

namespace OnlineLibraryProject.Web.Controllers
{
    public class BookController : Controller
    {
        //private context _context;
        private readonly BookRepository _bookRepository;
        public BookController(/*AppDbContext context*/)
        {
            _bookRepository = new BookRepository();
            //_context = context;
            //if (!_context.Books.Any())
            //{
            //    _context.Books.Add(new Book() { Name = "Kalem 1", Stock = 100, Year = 2001 ,PageNumber = 44 });
            //    _context.Books.Add(new Book() { Name = "Kalem 2", Stock = 200, Year = 2001 ,PageNumber = 44 });
            //    _context.Books.Add(new Book() { Name = "Kalem 3", Stock = 300, Year = 2001 ,PageNumber=44});

            //    _context.SaveChanges();
            //}

        }

        public IActionResult Index()
        {
            // var books = _context.Books.ToList();
            return View(/*books*/);
        }
        public IActionResult Remove(int id)
        {
            //var product = _context.Books.Find(id);
            //_context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            //var books = _context.Books.Find(id);
            return View(/*books*/);
        }
        [HttpPost]
        public IActionResult Update(/*Book updateBook,int bookId,string type*/)
        {
            //updateBook.Id= bookId;  
            //_context.Books.Update(updateBook);
            //_context.SaveChanges();

            TempData["status"] = "Ürün Başarıyla güncellendi";
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Add(/*Book newBook*/)
        //{
        //    //_context.Books.Add(newBook);
        //    //_context.SaveChanges();
        //    //TempData["status"] = "Ürün Başarıyla Eklendi";
        //    return RedirectToAction("index");
        //}
    } 
}
