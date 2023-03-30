namespace DesignPatterns_SocialMedia.Models
{
    public class TextPost : Post
    {
        protected override string Content { get; set; }
        

        public TextPost(string content, string title) : base(content, title)
        {
            Content = content;
        }

        public override string GetContent()
        {
            return Content;
        }
    }
}
