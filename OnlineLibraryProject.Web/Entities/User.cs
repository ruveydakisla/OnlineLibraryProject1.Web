using System.ComponentModel.DataAnnotations;

namespace OnlineLibraryProject.Web.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string? NameSurname { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
    }
}
