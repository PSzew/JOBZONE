using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOBZONE.Models
{
    public class CertificateModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? CertificateType { get; set; }

        [Required]
        public string? TrainingHost { get; set; }

        [Required]
        public DateTime TrainingEndDate { get; set; }

        [ForeignKey("UserId")]
        public virtual UserModel? UserModel { get; set; }
        public virtual int? UserId { get; set; }

    }
}
