using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

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
        [Range(1, 7, ErrorMessage = "Maksymalna liczba to 7!")]
        public int WorkDays { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        [Range(1, 12, ErrorMessage = "Maksymalna liczba to 7!")]
        public int WorkHours { get; set; }
        public DateTime? OfferColapseTime { get; set; } = DateTime.MinValue;

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Dueties { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Requirements { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Benefits { get; set;}

        public string? CompanyInfo { get; set; }
        public virtual CompanyModel? CompanyModel { get; set; }
        public virtual int? ComapnyId { get; set; }

    }
}
