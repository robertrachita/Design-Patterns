using DesignPatterns_SocialMedia.Models;
using DesignPatterns_SocialMedia.Models.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

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

        [HttpGet]
        public ActionResult ViewPost(int id)
        {
            Post post = getPostById(id);
            return View(post);
        }

        [HttpPost]
        public ActionResult ViewPost(int id, int content)
        {
            Post post = getPostById(id);

            var value = Request.Form["selectLike"].First() as String;
            LikeDecorator like = new LikeDecorator();

            switch(value)
            {
                case "2":
                    like = new SuperLikeDecorator();
                    break;
                case "3":
                    like = new DislikeDecorator();
                    break;
                default:
                    break;
            }
            
            post.AddLike(like);

            return RedirectToAction("Posts", "Posts");
        }

        private Post getPostById(int id)
        {
            foreach (var el in CreatedPosts.GetPosts())
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
