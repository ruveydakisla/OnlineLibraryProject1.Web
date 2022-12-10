using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }
        public User user { get; set; }  
        public Book book { get; set; }
        public int BookId { get; set; }
        public Guid UserID { get; set; }
        public string comment { get; set; } 
    }
}
