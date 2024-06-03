using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using JOBZONE.Models;
using static JOBZONE.Models.JobExperienceModel;

namespace JOBZONE.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Surname { get; set; }

        [Required]
        public DateTime? BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [PasswordPropertyText]
        public string? Password { get; set; }

        [Required]
        [Phone]
        public int? PhoneNumber { get; set; }

        [Required]
        public Uri? Image { get; set; }

        [Required]
        public string? Residence { get; set; }

        [System.ComponentModel.DefaultValue("Brak")]
        public string? ActualJob { get; set; }

        [System.ComponentModel.DefaultValue("Brak")]
        public string? ActaulJobDescription { get; set; }

        [Required]
        public string? JobExperienceDescripton { get; set; }
        public bool isAdmin { get; set; }

        public virtual ICollection<JobExperienceModel>? JobExperince { get; set; }

        public virtual ICollection<EducationModel>? Education { get; set; }

        public virtual ICollection<LanguageModel>? Languages { get; set; }

        [Required,System.ComponentModel.DefaultValue("Brak")]
        public string? SpecialSkill { get; set; }

        public virtual ICollection<CertificateModel>? Certificates { get; set; }
        public virtual ICollection<LinksModel>? Links { get; set; }
        public virtual ICollection<RecentlyViewedModel>? RecentlyVieved { get; set; }
        public virtual ICollection<AppliedModel>? Applied { get; set; }

    }
}
