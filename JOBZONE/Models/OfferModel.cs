using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOBZONE.Models
{
    public class OfferModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? Workplace { get; set; }

        [Required]
        public string? JobLevel { get; set; }

        [Required]
        public string? TypeOfContract { get; set; }

        [Required]
        public string? EmploymentType { get; set; }

        [Required]
        public string? JobType { get; set; }

        [Required]
        public decimal SalaryMin { get; set; }

        [Required]
        public decimal SalaryMax { get; set; }

        [Required]
        public int WorkDays { get; set; }

        [Required]
        public int WorkHours { get; set; }

        [Required]
        public DateTime? OfferColapseTime { get; set; }

        [Required]
        public string? Dueties { get; set; }

        [Required]
        public string? Requirements { get; set; }

        [Required]
        public string? Benefits { get; set; }

        [Required]
        public string? CompanyInfo { get; set; }

        [ForeignKey("ID")]
        public virtual CompanyModel? CompanyModel { get; set; }
        public virtual int? ComapnyId { get; set; }
    }
}
