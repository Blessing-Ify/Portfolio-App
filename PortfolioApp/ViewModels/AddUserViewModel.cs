using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.ViewModels
{
    public class AddUserViewModel
    {
        //view for registering new users
        [Required]
        [StringLength(30, ErrorMessage = "First name should be between 2 and 30", 
        MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "First name should be between 2 and 30", 
        MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format!")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }

    }
}
