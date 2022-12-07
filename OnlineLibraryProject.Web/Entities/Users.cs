using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineLibraryProject.Web.Entities
{
    [Table("Users")]
    public class Users
    {
        
        
            [Key]
            public Guid Id { get; set; }
        
            public string? NameSurname { get; set; }
            [Required]
            public string UserName { get; set; }
            [Required]
            [StringLength(100)]
            public string Password { get; set; }

            
            [Required]
            [StringLength( 300)]
            public string Address { get; set; }
            [Required]
            public string Role { get; set; } = "user";





    }
}
