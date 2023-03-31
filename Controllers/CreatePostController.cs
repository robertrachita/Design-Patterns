using DesignPatterns_SocialMedia.Models.Factory;
using DesignPatterns_SocialMedia.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_SocialMedia.Controllers
{
    public class CreatePostController : Controller
    {
        private readonly PostCreator textPostCreator = new TextPostCreator();
        private readonly PostCreator imagePostCreator = new ImagePostCreator();
        private readonly PostCreator videoPostCreator = new VideoPostCreator();
        private Post? post;

        private string? postTitle;
        private string? postContent;
        private string? postType;
        
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

                postType = Request.Form["postType"].First() as String;
                postTitle = Request.Form["postTitle"].First() as String;
                postContent = Request.Form["postContent"].First() as String;

                switch (postType)
                {
                    case "Text":
                        post = CreateTextPost(CreatedPosts.GetID(), postContent, postTitle);
                        CreatedPosts.IncreaseID();
                        CreatedPosts.AddPost(post);
                        break;
                    case "Image":
                        post = CreateImagePost(CreatedPosts.GetID(), postContent, postTitle);
                        CreatedPosts.IncreaseID();
                        CreatedPosts.AddPost(post);
                        break;
                    case "Video":
                        post = CreateVideoPost(CreatedPosts.GetID(), postContent, postTitle);
                        CreatedPosts.IncreaseID();
                        CreatedPosts.AddPost(post);
                        break;
                    default:
                        return RedirectToAction("Index", "Home");
                        break;
                }
                return RedirectToAction("Posts", "Posts");
            }
            catch
            {
                return View();
            }
        }

        private Post CreateTextPost(int id, String content, String title)
        {
            return textPostCreator.CreatePost(id, content, title);

        }

        private Post CreateImagePost(int id, String content, String title)
        {
            return imagePostCreator.CreatePost(id, content, title);
        }

        private Post CreateVideoPost(int id, String content, String title)
        {
            return videoPostCreator.CreatePost(id, content, title);
        }


    }
}
