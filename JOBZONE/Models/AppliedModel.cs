using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOBZONE.Models
{
    public class AppliedModel
    {
        [Key]
        public int ID { get; set; }

        public int OfferID { get; set; }

        public string? Status { get; set; }

        public virtual UserModel? UserModel { get; set; }
        public virtual string? UserId { get; set; }
    }
}
