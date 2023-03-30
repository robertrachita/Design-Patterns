using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_SocialMedia.Models.Factory
{
    public abstract class PostCreator : Controller
    {
        public abstract Post CreatePost(string content, string title);
    }
}
