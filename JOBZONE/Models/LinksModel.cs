using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOBZONE.Models
{
    public class LinksModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public Uri? Link { get; set; }

        [ForeignKey("UserId")]
        public virtual UserModel? UserModel { get; set; }
        public virtual int? UserId { get; set; }
    }
}
