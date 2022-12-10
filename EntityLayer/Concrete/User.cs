using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }

        public string? NameSurname { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        [StringLength(300)]
        public string Address { get; set; }
        [Required]
        public string Role { get; set; } = "user";
    }
}
