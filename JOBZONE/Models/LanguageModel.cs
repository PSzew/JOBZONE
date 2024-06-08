using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOBZONE.Models
{
    public class LanguageModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? Language { get; set; }

        [Required]
        public string? LanguageLevel { get; set; }

        public virtual UserModel? UserModel { get; set; }
        public virtual string? UserId { get; set; }
    }
}
