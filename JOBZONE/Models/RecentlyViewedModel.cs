using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOBZONE.Models
{
    public class RecentlyViewedModel
    {
        [Key]
        public int ID { get; set; }

        public int OfferID { get; set; }

        [ForeignKey("UserId")]
        public virtual UserModel? UserModel { get; set; }
        public virtual int? UserId { get; set; }
    }
}
