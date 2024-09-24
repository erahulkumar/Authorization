using System.ComponentModel.DataAnnotations;

namespace WebLoginAuth.Authentication
{
    public class LoginModel
    {
        [Required(ErrorMessage ="User name is required")]
        public required string Username { get; set; }

        [Required(ErrorMessage ="Password is required")]
        public required string Password { get; set; }

    }
}
