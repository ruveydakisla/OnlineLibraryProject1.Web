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
    public class UserRepostory : IUserDal
    {
        public void Delete(User t)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            using var context= new Context();
            context.Remove(user);
            context.SaveChanges();
        }

        public User GetByID(int id)
        {
            using var context = new Context();
            return context.Users.Find(id);
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(User t)
        {
            throw new NotImplementedException();
        }

        public List<User> ListAllUsers()
        {
            using var context = new Context();
            return context.Users.ToList();
        }

        public void Update(User t)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            using var context = new Context();
            context.Update(user);
            context.SaveChanges();
        }

        public void UserAdd(User user)
        {
            using var context = new Context();
            context.Add(user);
            context.SaveChanges();
        }
    }
}
