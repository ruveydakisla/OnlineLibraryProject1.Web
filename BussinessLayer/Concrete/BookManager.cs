using BussinessLayer.Abstract;
using DataAccessLayer.Abstact;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookdal;

        public BookManager(IBookDal bookdal)
        {
            _bookdal = bookdal;
        }

        public void BookAdd(Book book)
        {
            _bookdal.Insert(book);

        }

        public void BookRemove(Book book)
        {
            _bookdal.Delete(book);
        }

        public void BookUpdate(Book book)
        {
            _bookdal.Update(book);
        }

        public List<Book> GetAllBooks()
        {
            return _bookdal.GetListAll();
        }

        public Book GetById(int id)
        {
            return _bookdal.GetById(id);
        }
    }
}
