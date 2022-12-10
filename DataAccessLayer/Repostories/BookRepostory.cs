using DataAccessLayer.Abstact;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repostories
{
    public class BookRepostory : IBookDal
    {
       
        public void BookAdd(Book book)
        {
            using var context = new Context();
            context.Books.Add(book);
            context.SaveChanges();
        }

        public void Delete(Book t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Book book)
        {
           using var context=new Context();
            context.Books.Remove(book);
            context.SaveChanges();
        }

        public Book GetByID(int id)
        {
           using var context=new Context();
            return context.Books.Find(id);
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Book t)
        {
            throw new NotImplementedException();
        }

        public List<Book> ListAllBooks()
        {
            using var context = new Context();
            return context.Books.ToList();
        }

        public void Update(Book t)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            using var context = new Context();
            context.Books.Update(book);
            context.SaveChanges();

        }
    }
}
