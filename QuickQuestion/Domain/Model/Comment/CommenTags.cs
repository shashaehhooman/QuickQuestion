using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class CommenTags
    {
        [Key]
        public int id { get; set; }
        public int comentId { get; set; }
        public int? answerId { get; set; }
        public int tagId { get; set; }
        public int userId { get; set; }
        public DateTime created { get; set; }



        [ForeignKey("commentId")]
        public virtual Comment comment { get; set; }

        [ForeignKey("answerId")]
        public virtual Answer answer { get; set; }

        [ForeignKey("tagId")]
        public virtual Tag tag { get; set; }

        [ForeignKey("userId")]
        public virtual User user { get; set; }
    }
}
