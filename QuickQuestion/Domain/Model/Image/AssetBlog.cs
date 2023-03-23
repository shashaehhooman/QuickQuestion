using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class AssetBlog
    {
        public int id { get; set; }
        public string fileName { get; set; }
        public int userId { get; set; }
        public int blogId { get; set; }
        public AssetType assetType { get; set; }
        public DateTime created { get; set; }



        [ForeignKey("userId")]
        public virtual User user { get; set; }
        [ForeignKey("blogId")]
        public virtual Blog blog { get; set; }

    }
}
