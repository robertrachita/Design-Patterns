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
                Console.WriteLine("trying");
                ViewData["postTitle"] = Request.Form["postTitle"].First();
                ViewData["postContent"] = Request.Form["postContent"].First();

                return View();
            }
            catch
            {
                Console.WriteLine("error");
                return View();
            }
        }
    }
}
