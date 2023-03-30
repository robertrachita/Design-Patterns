namespace DesignPatterns_SocialMedia.Models
{
    public class ImagePost : Post
    {
        protected override string Content { get; set; }

        public ImagePost(string content, string title) : base(content, title)
        {
            Content = content;
        }

        public override string GetContent()
        {
            return Content;
        }
    }
}
