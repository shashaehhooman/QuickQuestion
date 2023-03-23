using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class Category
    {
        public Category()
        {
            subs = new HashSet<Category>();
            assets = new HashSet<AssetCategory>();
        }


        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string shortDescription { get; set; }
        public string content { get; set; }
        public string metaTags { get; set; }
        public int? superId { get; set; }
        public DateTime created { get; set; }


        [ForeignKey("superId")]
        public virtual Category super { get; set; }
        public virtual ICollection<Category> subs { get; set; }
        public virtual ICollection<AssetCategory> assets { get; set; }



        public string FullTitle()
        {
            if (this.super == null)
                return this.title;
            else
                return this.super.FullTitle() + " - " + this.title;
        }
    }
}
