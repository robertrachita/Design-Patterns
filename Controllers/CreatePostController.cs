using DesignPatterns_SocialMedia.Models.Factory;
using DesignPatterns_SocialMedia.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_SocialMedia.Controllers
{
    public class CreatePostController : Controller
    {
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePost(string title, string content)
        {
            try
            {
                ViewData["postTitle"] = Request.Form["postTitle"].First();
                ViewData["postContent"] = Request.Form["postContent"].First();
                ViewData["postType"] = Request.Form["postType"].First();

                TempData["postTitle"] = Request.Form["postTitle"].First();
                TempData["postContent"] = Request.Form["postContent"].First();
                TempData["postType"] = Request.Form["postType"].First();


                return RedirectToAction("Posts", "Posts");
            }
            catch
            {
                return View();
            }
        }

    }
}
