using DesignPatterns_SocialMedia.Models;

namespace DesignPatterns_SocialMedia.Controllers
{
    public class VideoPostCreator : PostCreator
    {
        public override Post CreatePost(String content, String title)
        {
            return new VideoPost(content, title);
        }
    }
}
