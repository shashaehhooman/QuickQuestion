namespace QuickQuestion.Model
{
    public class CommentDto
    {
        public int? blogId { get; set; }
        public string title { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
    }
}
