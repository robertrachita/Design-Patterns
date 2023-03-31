using DesignPatterns_SocialMedia.Models;
using DesignPatterns_SocialMedia.Models.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_SocialMedia.Controllers
{
    public class PostsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PostCreator textPostCreator = new TextPostCreator();
        private Post post, post2;
        private List<Post> posts;

        public PostsController(ILogger<HomeController> logger)
        {
            _logger = logger;
            posts = new List<Post>();
            post = CreateTextPost(1, "This is the content", "This is the title");
            post2 = CreateTextPost(2, "This is the content2", "This is the title2");
            posts.Add(post);
            posts.Add(post2);
        }
        private Post CreateTextPost(int id,String content, String title)
        {
            return textPostCreator.CreatePost(id, content, title);
        }
        
        public IActionResult Posts()
        {
            return View(posts);
        }

        [HttpGet]
        public IActionResult ViewPost(int id) 
        {
            Post post = getPostById(id);
            return View(post);
        }

        private Post getPostById(int id)
        {
            foreach (var el in posts)
            {
                if (el.GetId() == id)
                {
                    return el;
                }
            }
            return null;
        }

    }
}
