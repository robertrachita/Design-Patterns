using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_SocialMedia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["postTitle"] = TempData["postTitle"];
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }

        public IActionResult CreatePost()
        {
            return View();
        }
    }
}