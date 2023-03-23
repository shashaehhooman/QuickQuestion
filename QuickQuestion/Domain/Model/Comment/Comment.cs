using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class Comment
    {
        public Comment()
        {
            answers = new HashSet<Answer>();
            commenTsags = new HashSet<CommenTags>();
            assetComments = new HashSet<AssetComment>();
        }


        [Key]
        public int id { get; set; }
        public int? blogId { get; set; }
        public int userId { get; set; }
        [MaxLength(1500), Required]
        public string title { get; set; }
        [MaxLength(2500), Required]
        public string description { get; set; }
        public DateTime created { get; set; }



        [ForeignKey("blogId")]
        public virtual Blog blog { get; set; }
        [ForeignKey("userId")]
        public virtual User user { get; set; }
        public virtual ICollection<Answer> answers { get; set; }
        public virtual ICollection<CommenTags> commenTsags { get; set; }
        public virtual ICollection<AssetComment> assetComments { get; set; }
    }
}
