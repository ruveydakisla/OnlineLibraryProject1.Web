using BusinessLayer.Abstract;
using DataAccessLayer.Abstact;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReadingGroupManager : IReadingGroupService
    {
        IReadingGroupDal _readingGroupDal;

        public ReadingGroupManager(IReadingGroupDal readingGroupDal)
        {
            _readingGroupDal = readingGroupDal;
        }

        public void DeleteReadingGroup(ReadingGroup readingGroup)
        {
            if (readingGroup.GroupID != 0)
            {
                _readingGroupDal.Delete(readingGroup);
            }
        }

        public ReadingGroup GetById(int id)
        {
            return _readingGroupDal.GetById(id);
        }

        public List<ReadingGroup> Getlist()
        {
            return _readingGroupDal.GetListAll();
        }

        public void ReadingGroupAdd(ReadingGroup readingroup)
        {
            _readingGroupDal.Insert(readingroup);
        }

        public void UpdateReadingGroup(ReadingGroup readingGroup)
        {
            _readingGroupDal.Update(readingGroup);
        }
    }
}
