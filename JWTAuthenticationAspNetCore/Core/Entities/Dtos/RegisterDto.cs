using System.ComponentModel.DataAnnotations;

namespace JWTAuthenticationAspNetCore.Core.Entities.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}