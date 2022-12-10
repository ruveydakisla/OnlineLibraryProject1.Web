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
    public class TakenBookRepostory : ITakenBookDal
    {
        public void Delete(TakenBook t)
        {
            throw new NotImplementedException();
        }

        public void DeleteTakenBook(TakenBook takenBook)
        {
            using var context = new Context();
            context.Remove(takenBook);
            context.SaveChanges();
        }

        public TakenBook GetByID(int id)
        {
            using var context=new Context();
            return context.TakenBooks.Find(id);
        }

        public TakenBook GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TakenBook> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(TakenBook t)
        {
            throw new NotImplementedException();
        }

        public List<TakenBook> ListAllUsers()
        {
            using var context=new Context();
            return context.TakenBooks.ToList();
        }

        public void TakenBookAdd(TakenBook takenBook)
        {
            using var context = new Context(); 
            context.Add(takenBook);
            context.SaveChanges();
        }

        public void Update(TakenBook t)
        {
            throw new NotImplementedException();
        }

        public void UpdateTakenBook(TakenBook takenBook)
        {
            using var context=new Context();
            context.Update(takenBook);
            context.SaveChanges();
        }
    }
}
