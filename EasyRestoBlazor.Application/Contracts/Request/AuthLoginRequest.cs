using System.ComponentModel.DataAnnotations;

namespace EasyRestoBlazor.Application.Contracts.Request
{
    public class AuthLoginRequest
    {
        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        [MinLength(5, ErrorMessage = "Password must be at least 5 characters long.")]
        public string Password { get; set; }
    }
}
