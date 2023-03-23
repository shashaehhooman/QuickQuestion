using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class AssetCategory
    {
        public int id { get; set; }
        public string fileName { get; set; }
        public int userId { get; set; }
        public int categoryId { get; set; }
        public AssetType assetType { get; set; }
        public DateTime created { get; set; }



        [ForeignKey("userId")]
        public virtual User user { get; set; }
        [ForeignKey("categoryId")]
        public virtual Category category { get; set; }
    }
}
