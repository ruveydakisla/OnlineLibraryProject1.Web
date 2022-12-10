using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReadingGroupService
    {
        void ReadingGroupAdd(ReadingGroup readingroup);
        void DeleteReadingGroup(ReadingGroup readingGroup);
        void UpdateReadingGroup(ReadingGroup readingGroup);
        List<ReadingGroup> Getlist();
        ReadingGroup GetById(int id);
    }
}
