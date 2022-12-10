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
    public class ReadingGroupRepository : IReadingGroupDal
    {
        public void Delete(ReadingGroup t)
        {
            throw new NotImplementedException();
        }

        public void DeleteReadingGroup(ReadingGroup group)
        {
            using var context = new Context();
            context.Remove(group);
            context.SaveChanges();
        }

        public ReadingGroup GetByID(int id)
        {
            using var context= new Context();
            return context.ReadingGroups.Find(id);
        }

        public ReadingGroup GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReadingGroup> GetListAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(ReadingGroup t)
        {
            throw new NotImplementedException();
        }

        public List<ReadingGroup> ListAllGroups()
        {
            using var context=new Context();
            return context.ReadingGroups.ToList();
        }

        public void ReadingGroupAdd(ReadingGroup group)
        {
            using var context=new Context();
            context.Add(group);
            context.SaveChanges();
        }

        public void Update(ReadingGroup t)
        {
            throw new NotImplementedException();
        }

        public void UpdateReadingGroup(ReadingGroup group)
        {
            using var context=new Context();
            context.Update(group);
            context.SaveChanges();
        }
    }
}
