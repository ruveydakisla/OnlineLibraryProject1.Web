using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Year { get; set; }
        public int PageNumber { get; set; }
        public string BookCategory { get; set; }
        public string Bookinfo { get; set; }
        public string BookImage { get; set; }
        public string AuthorName { get; set; }
        public string AuthorAbout { get; set; }
        public string AuthorQuintessence { get; set; }
        public Author? author { get; set; }
        public List<Comment>? comments { get; set; }
    }
}
