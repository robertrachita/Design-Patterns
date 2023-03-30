using DesignPatterns_SocialMedia.Models;
using DesignPatterns_SocialMedia.Models.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_SocialMedia.Controllers
{
    public class PostsController : Controller
    {
        private readonly PostCreator textPostCreator = new TextPostCreator();
        //create a post as variable
        private Post post, post2;
        //initialise the post

        private Post CreateTextPost(string content, string title)
        {
            return textPostCreator.CreatePost(content, title);
        }

        public ActionResult Index()
        {
            post = CreateTextPost("This is the content", "This is the title");
            post2 = CreateTextPost("This is the content2", "This is the title2");
            return View();
        }

        // GET: PostsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
