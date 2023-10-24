using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JOBZONE.Models
{
    public class JobExperienceModel
    {
            [Key]
            public int JobExperienceId { get; set; }

            [System.ComponentModel.DefaultValue("Brak")]
            public string? JobFunction { get; set; }

            [System.ComponentModel.DefaultValue("Brak")]
            public string? CompanyName { get; set; }

            [System.ComponentModel.DefaultValue("Brak")]
            public string? ComapnyLocation { get; set; }

            [Required]
            public DateTime EmployedSince { get; set; }

            [Required]
            public DateTime EmployedTo { get; set; }

            [System.ComponentModel.DefaultValue("Brak")]
            public string? Responsibilites { get; set; }

            [ForeignKey("UserId")]
            public virtual UserModel? UserModel { get; set; }
            public virtual int? UserId { get; set; }

    }
}
