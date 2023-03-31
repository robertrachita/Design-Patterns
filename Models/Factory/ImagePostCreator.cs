namespace DesignPatterns_SocialMedia.Models.Factory
{
    public class ImagePostCreator : PostCreator
    {
        public override Post CreatePost(int id, String content, String title)
        {
            return new ImagePost(id, content, title);
        }
    }
}
