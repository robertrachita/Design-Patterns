using DesignPatterns_SocialMedia.Models;

namespace DesignPatterns_SocialMedia.Controllers
    
{
    public class TextPostCreator : PostCreator
    {
        public override Post CreatePost(String content, String title)
        {
            return new TextPost(content, title);
        }
    }

}
