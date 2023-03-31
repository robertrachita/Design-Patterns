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

                string postTitle = Request.Form["postTitle"].First();
                string postContent = Request.Form["postContent"].First();

                TempData["postTitle"] = postTitle;
                TempData["postContent"] = postContent;

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
