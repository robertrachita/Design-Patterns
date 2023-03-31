namespace DesignPatterns_SocialMedia.Models.Factory
{
    public class VideoPostCreator : PostCreator
    {
        public override Post CreatePost(int id, String content, String title)
        {
            return new VideoPost(id, content, title);
        }
    }
}
