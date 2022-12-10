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
    public class UserManager : IUserService
    {
        IUserDal _userdal;
        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }

        public List<User> GetAllUsers()
        {
            return _userdal.GetListAll();
        }

        public User GetById(int id)
        {
            return _userdal.GetById(id);
        }

        public void UserAdd(User user)
        {
            _userdal.Insert(user);
        }

        public void UserRemove(User user)
        {
            _userdal.Delete(user);
        }

        public void UserUpdate(User user)
        {
            _userdal.Update(user);
        }
    }
}
