using System.ComponentModel.DataAnnotations;

namespace WebLoginAuth.Authentication
{
    public class RegisterModel
    {
        [Required(ErrorMessage="User name is required")]
        public required string Username {  get; set; }
        
        [EmailAddress]
        [Required(ErrorMessage ="Email is required")]
        public required string Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public required string Password { get; set; }
    }
}
