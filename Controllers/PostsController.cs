using DesignPatterns_SocialMedia.Models;
using DesignPatterns_SocialMedia.Models.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_SocialMedia.Controllers
{
    public class PostsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly PostCreator textPostCreator = new TextPostCreator();
        //private readonly PostCreator imagePostCreator = new ImagePostCreator();
        //private readonly PostCreator videoPostCreator = new VideoPostCreator();
        //private Post post, post1, post2, post3, post4;
        //private List<Post> posts;
        //private int id = 5;


        //string? postTitle;
        //string? postContent;
        //string? postType;

        public PostsController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //private Post CreateTextPost(int id, String content, String title)
        //{
        //    return textPostCreator.CreatePost(id, content, title);
        
        //}

        //private Post CreateImagePost(int id, String content, String title)
        //{
        //    return imagePostCreator.CreatePost(id, content, title);
        //}

        //private Post CreateVideoPost(int id, String content, String title)
        //{
        //    return videoPostCreator.CreatePost(id, content, title);
        //}

        public IActionResult Posts()
        {
            return View(CreatedPosts.GetPosts());
        }

        //public IActionResult CreatedPost()
        //{
        //    postType = TempData["postType"] as String;
        //    postTitle = TempData["postTitle"] as String;
        //    postContent = TempData["postContent"] as String;

        //    switch (postType)
        //    {
        //        case "Text":
        //            post = CreateTextPost(id, postContent, postTitle);
        //            id++;
        //            break;
        //        case "Image":
        //            post = CreateImagePost(id, postContent, postTitle);
        //            id++;
        //            break;
        //        case "Video":
        //            post = CreateVideoPost(id, postContent, postTitle);
        //            id++;
        //            break;
        //        default:
        //            break;
        //    }
        //    posts.Add(post);

        //    return View(posts);
        //}

    }
}
