using System.ComponentModel.DataAnnotations;

namespace BookLibrary.Data.Entities
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Stock { get; set; }
        public int year { get; set; }

    }
}