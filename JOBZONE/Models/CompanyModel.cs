using System.ComponentModel.DataAnnotations;

namespace JOBZONE.Models
{
    public class CompanyModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Adres { get; set; }
        public Uri ComapnyImg { get; set; }
        public virtual ICollection<JobOfferModel>? JobOfferModel { get; set; }
    }
}
