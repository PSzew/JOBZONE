using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOBZONE.Models
{
    public class CertificateModel
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? CertificateType { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string? TrainingHost { get; set; }
        
        public DateTime TrainingEndDate { get; set; }

        public virtual UserModel? UserModel { get; set; }
        public virtual string? UserId { get; set; }

    }
}
