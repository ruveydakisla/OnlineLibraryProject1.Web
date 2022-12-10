using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TakenBook
    {
        public int TakenBookID { get; set; }
        
        public int BookID { get; set; }
        public Book book { get; set; }
        public User user { get; set; }
        public Guid UserID { get; set; }
    }
}
