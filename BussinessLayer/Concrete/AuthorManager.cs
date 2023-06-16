using BussinessLayer.Abstract;
using DataAccessLayer.Abstact;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        IAuthorsDal _authordal;

        public AuthorManager(IAuthorsDal authordal)
        {
            _authordal = authordal;
        }

        public void AuthorAdd(Author Author)
        {
            _authordal.Insert(Author);
        }

        public void AuthorRemove(Author Author)
        {
            _authordal.Delete(Author);

        }

        public void AuthorUpdate(Author Author)
        {
            _authordal.Update(Author);
        }

        public List<Author> GetAllAuthors()
        {
            return _authordal.GetListAll();
        }

        public Author GetById(int id)
        {
            return _authordal.GetById(id);
        }
    }
}
