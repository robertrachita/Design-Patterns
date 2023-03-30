namespace DesignPatterns_SocialMedia.Models.Factory
{
    public class ImagePostCreator : PostCreator
    {
        public override Post CreatePost(string content, string title)
        {
            return new ImagePost(content, title);
        }
    }
}
