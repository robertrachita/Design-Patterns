namespace DesignPatterns_SocialMedia.Models
{
    public class VideoPost : Post
    {
        protected override string Content { get; set; }

        public VideoPost(string content, string title) : base(content, title)
        {
            Content = content;
        }

        public override string GetContent()
        {
            return Content;
        }
    }
}
