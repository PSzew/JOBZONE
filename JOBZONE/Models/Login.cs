using Microsoft.Build.Framework;

namespace JOBZONE.Models
{
    public class Login
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
