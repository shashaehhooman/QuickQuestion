using System.ComponentModel.DataAnnotations.Schema;

namespace QuickQuestion.Domain.Model
{
    public class AssetComment
    {
        public int id { get; set; }
        public string fileName { get; set; }
        public int userId { get; set; }
        public int commentId { get; set; }
        public int? answerId { get; set; }
        public AssetType assetType { get; set; }
        public DateTime created { get; set; }


        [ForeignKey("commentId")]
        public virtual Comment comment { get; set; }
        [ForeignKey("answerId")]
        public virtual Answer answer { get; set; }
    }
}
