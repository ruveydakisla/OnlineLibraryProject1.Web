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
    internal class AuthorRepostory : IAuthorsDal
    {
        public void AuthorAdd(Author author)
        {
            using var context = new Context();
            context.Authors.Add(author);
            context.SaveChanges();
        }

        public void Delete(Author t)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuthor(Author author)
        {
           using var context=new Context();
            context.Authors.Remove(author);
            context.SaveChanges();
        }

        public Author GetByID(int id)
        {
          using var context =new Context();
            return context.Authors.Find(id);
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Author t)
        {
            throw new NotImplementedException();
        }

        public List<Author> ListAllAuthors()
        {
            using var context =new Context();
            return context.Authors.ToList();
        }

        public void Update(Author t)
        {
            throw new NotImplementedException();
        }

        public void UpdateAuthor(Author author)
        {
            using var context = new Context();
            context.Authors.Update(author);
            context.SaveChanges();
        }
    }
}
