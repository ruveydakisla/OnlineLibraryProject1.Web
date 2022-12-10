using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IBookService
    {
        void BookAdd(Book book);
        void BookRemove(Book book);
        void BookUpdate(Book book);
        List<Book> GetAllBooks();
        Book GetById(int id);

    }
}
