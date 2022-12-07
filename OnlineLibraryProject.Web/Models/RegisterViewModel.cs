using System.ComponentModel.DataAnnotations;

namespace OnlineLibraryProject.Web.Models
{
    public class RegisterViewModel:LoginViewModel
    {
        [Required]
        [Compare(nameof(Password))]
       
        public string RePassword { get; set; }
        public string NameSurname { get; set; }

        public string Address { get; set; }


    }
}
