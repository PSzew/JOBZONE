using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace JOBZONE.Models
{
    public class EducationModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        [System.ComponentModel.DefaultValue("Podstawowe")]
        public string? EducationLevel { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? SchoolName { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Town { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Proffesion { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public DateTime StartDate { get; set; }

        [AllowNull]
        public DateTime EndDate { get; set; }

        public virtual UserModel? UserModel { get; set; }
        public virtual string? UserId { get; set; }
    }
}
