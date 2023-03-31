namespace DesignPatterns_SocialMedia.Models
{
    public class VideoPost : Post
    {
        protected override String Content { get; set; }

        public VideoPost(int id, String content, String title) : base(id, content, title)
        {
            Content = content;
        }

        public override string GetContent()
        {
            return Content;
        }
    }
}
