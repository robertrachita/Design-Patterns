namespace DesignPatterns_SocialMedia.Models.Factory
{
    public class VideoPostCreator : PostCreator
    {
        public override Post CreatePost(string content, string title)
        {
            return new VideoPost(content, title);
        }
    }
}
