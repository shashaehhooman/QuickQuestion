using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class Blog
    {
        public Blog()
        {
            blogTags = new HashSet<BlogTags>();
            assets = new HashSet<AssetBlog>();
            comments = new HashSet<Comment>();
        }

        [Key]
        public int id { get; set; }
        public int categoryId { get; set; }
        public int userId { get; set; }
        public int index { get; set; } = 0;
        public string title { get; set; }
        public string shortDescription { get; set; }
        public string content { get; set; }
        public string metaTags { get; set; }
        public DateTime created { get; set; }



        [ForeignKey("categoryId")]
        public virtual Category category { get; set; }
        [ForeignKey("userId")]
        public virtual User user { get; set; }
        public virtual ICollection<BlogTags> blogTags { get; set; }
        public virtual ICollection<AssetBlog> assets { get; set; }
        public virtual ICollection<Comment> comments { get; set; }


        public string FullTitle()
        {
            if (this.category == null)
                return this.title;
            else
                return this.category.FullTitle() + " - " + this.title;
        }
    }
}
