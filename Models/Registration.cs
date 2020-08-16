using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Equal.Models
{
    public class Registration
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter first name.")]
        [MinLength(2, ErrorMessage = "Name must be longer than 2 characters")]
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter last name.")]
        [MinLength(2, ErrorMessage = "Name must be longer than 2 characters")]
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter email.")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Display(Name = "Email: ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [MinLength(8, ErrorMessage = "Password must be a minimum of 8 characters long")]
        [Compare("Confirm", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        [Display(Name = "Password: ")]
        public string Password { get; set; }

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password: ")]
        public string Confirm { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt { get; set; } = DateTime.Now;
    }
}