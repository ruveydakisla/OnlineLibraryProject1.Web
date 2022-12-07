using System.ComponentModel.DataAnnotations;

namespace OnlineLibraryProject.Web.Models
{
    public class RegisterViewModel:LoginViewModel
    {
        [Required]
        [Compare(nameof(Password))]
       
        public String RePassword { get; set; }
    }
}
