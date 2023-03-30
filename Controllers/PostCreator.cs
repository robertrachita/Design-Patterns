using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DesignPatterns_SocialMedia.Models;

namespace DesignPatterns_SocialMedia.Controllers
{
    public abstract class PostCreator : Controller
    {
        public abstract Post CreatePost(String content, String title);
    }
}
