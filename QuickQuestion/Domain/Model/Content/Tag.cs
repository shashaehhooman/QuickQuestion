using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class Tag
    {
        public Tag()
        {
            blogTags = new HashSet<BlogTags>();
            commenTsags = new HashSet<CommenTags>();
        }


        [Key]
        public int id { get; set; }

        [MaxLength(250)]
        public string title { get; set; } = "";
        public int userId { get; set; }
        public DateTime created { get; set; }


        public virtual ICollection<BlogTags> blogTags { get; set; }
        public virtual ICollection<CommenTags> commenTsags { get; set; }
    }
}
