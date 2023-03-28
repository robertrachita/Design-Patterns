using DesignPatterns_SocialMedia.Models;

namespace DesignPatterns_SocialMedia.Controllers
{
    public class ImagePostCreator : PostCreator
    {
        public override Post CreatePost(String content, String title)
        {
            return new ImagePost(content, title);
        }
    }
}
