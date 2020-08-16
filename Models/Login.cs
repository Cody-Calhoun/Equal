using System.ComponentModel.DataAnnotations;

namespace Equal.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Please use valid email")]
        [Display(Name = "Email: ")]

        public string Email { get; set; }

        [Required]
        [Display(Name = "Password: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}