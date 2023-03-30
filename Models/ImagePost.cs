namespace DesignPatterns_SocialMedia.Models
{
    public class ImagePost : Post
    {
        protected override String Content { get; set; }

        public ImagePost(int id, String content, string title) : base(id, content, title)
        {
            Content = content;
        }

        public override string GetContent()
        {
            return Content;
        }
    }
}
