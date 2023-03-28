namespace DesignPatterns_SocialMedia.Models
{
    public class TextPost : Post
    {
        protected override String Content { get; set; }

        public TextPost(String content, String title) : base(content, title)
        {
            this.Content = content;
        }

        public override String GetContent()
        {
            return this.Content;
        }
    }
}
