using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class Answer
    {
        public Answer()
        {
            commenTsags = new HashSet<CommenTags>();
        }


        [Key]
        public int id { get; set; }
        public int commetnId { get; set; }
        public int userId { get; set; }
        [MaxLength(1500), Required]
        public string description { get; set; }
        public DateTime created { get; set; }



        [ForeignKey("commetnId")]
        public virtual Comment comment { get; set; }
        [ForeignKey("userId")]
        public virtual User user { get; set; }
        public virtual ICollection<CommenTags> commenTsags { get; set; }
    }
}
