using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class BlogTags
    {
        [Key]
        public int id { get; set; }
        public int blogId { get; set; }
        public int tagId { get; set; }
        public int userId { get; set; }

        public DateTime created { get; set; }




        [ForeignKey("blogId")]
        public virtual Blog blog { get; set; }

        [ForeignKey("tagId")]
        public virtual Tag tag { get; set; }
    }
}
