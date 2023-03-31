using DesignPatterns_SocialMedia.Models;
using DesignPatterns_SocialMedia.Models.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_SocialMedia.Controllers
{
    public class PostsController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public PostsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Posts()
        {
            return View(CreatedPosts.GetPosts());
        }
    }
}
