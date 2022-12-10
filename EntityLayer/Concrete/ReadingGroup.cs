using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ReadingGroup
    {
        [Key]
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public List<User> Users { get; set; }

    }
}
