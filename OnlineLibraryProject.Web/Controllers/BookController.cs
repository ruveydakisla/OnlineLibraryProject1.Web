using BussinessLayer.Concrete;
using DataAccessLayer.Abstact;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

using OnlineLibraryProject.Web.Models;
using System.Collections.Generic;

namespace OnlineLibraryProject.Web.Controllers
{
    public class BookController : Controller
    {
        private Context _context;
        BookManager bm = new BookManager(new EfBookRepository());
        public BookController(Context context)
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
        public IActionResult Remove(int id)
        {
            var book = bm.GetById(id);
            bm.BookRemove(book);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var book = bm.GetById(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Update(Book updateBook,int bookId,string type)
        {

            updateBook.BookID= bookId;  
            bm.BookUpdate(updateBook);
            TempData["status"] = "Kitap Başarıyla güncellendi";
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Book newBook)
        {
            bm.BookAdd(newBook);
            TempData["status"] = "Ürün Başarıyla Eklendi";
            return RedirectToAction("index");
        }
    } 
}
