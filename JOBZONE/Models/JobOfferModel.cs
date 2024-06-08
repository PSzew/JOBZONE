using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOBZONE.Models
{
    public class JobOfferModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Workplace { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? JobLevel { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? TypeOfContract { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? EmploymentType { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? JobType { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public decimal SalaryMin { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public decimal SalaryMax { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public int WorkDays { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public int WorkHours { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public DateTime? OfferColapseTime { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Dueties { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Requirements { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Benefits { get; set;}

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? CompanyInfo { get; set; }
        public virtual CompanyModel? CompanyModel { get; set; }
        public virtual int? ComapnyId { get; set; }

    }
}
