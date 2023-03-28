namespace DesignPatterns_SocialMedia.Models
{
    public class ImagePost : Post
    {
        protected override String Content { get; set; }

        public ImagePost(String content, String title) : base(content, title)
        {
            this.Content = content;
        }

        public override String GetContent()
        {
            return this.Content;
        }
    }
}
