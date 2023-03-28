namespace DesignPatterns_SocialMedia.Models
{
    public class VideoPost : Post
    {
        protected override String Content { get; set; }

        public VideoPost(String content, String title) : base(content, title)
        {
            this.Content = content;
        }

        public override String GetContent()
        {
            return this.Content;
        }
    }
}
