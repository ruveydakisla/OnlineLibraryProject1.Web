using System.ComponentModel.DataAnnotations;

namespace OnlineLibraryProject.Web.Entities
{
    public class Writer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Stock { get; set; }
        public int year { get; set; }
    }
}
