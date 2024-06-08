using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JOBZONE.Models
{
    public class Register
    {
        [Required(ErrorMessage ="Pole imie jest wymagane")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Pole nazwisko jest wymagane")]
        public string SurName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage ="Podano nie prawidłowy e-mail")]
        public string Email { get; set; }

        [Required]
        public string Telephone { get; set; }

        [Required]
        public string Password { get; set; }

        [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane")]
        [Compare("Password", ErrorMessage = "Podane hasła nie pasują do siebie")]
        public string RepeatPassword { get; set; }
    }
}
