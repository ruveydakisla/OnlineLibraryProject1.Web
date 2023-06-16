using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IAuthorService
    {
        void AuthorAdd(Author Author);
        void AuthorRemove(Author Author);
        void AuthorUpdate(Author Author);
        List<Author> GetAllAuthors();
        Author GetById(int id);
    }
}
