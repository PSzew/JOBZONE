using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.ComponentModel.DataAnnotations;

namespace JOBZONE.Models
{
    public class CompanyModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? Adres { get; set; }
        public Uri? ComapnyImg { get; set; }
        public virtual ICollection<JobOfferModel>? JobOfferModel { get; set; }
    }
}
