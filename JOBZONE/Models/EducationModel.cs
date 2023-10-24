using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOBZONE.Models
{
    public class EducationModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [System.ComponentModel.DefaultValue("Podstawowe")]
        public string? EducationLevel { get; set; }

        [Required]
        public string? SchoolName { get; set; }

        [Required]
        public string? Town { get; set; }

        [Required]
        public string? Proffesion { get; set; }

        [Required]
        public DateTime Peroid { get; set; }

        [ForeignKey("UserId")]
        public virtual UserModel? UserModel { get; set; }
        public virtual int? UserId { get; set; }
    }
}
