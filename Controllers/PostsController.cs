using DesignPatterns_SocialMedia.Models;
using DesignPatterns_SocialMedia.Models.Factory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns_SocialMedia.Controllers
{
    public class PostsController : Controller
    {
        private readonly PostCreator textPostCreator = new TextPostCreator();
        private Post post, post2;
        private List<Post> posts = new List<Post>();

        private Post CreateTextPost(int id,String content, String title)
        {
            return textPostCreator.CreatePost(id, content, title);
        }

        public ActionResult Posts()
        {
            post = CreateTextPost(1, "This is the content", "This is the title");
            post2 = CreateTextPost(2, "This is the content2", "This is the title2");
            posts.Add(post);
            posts.Add(post2);
            return View(posts);
        }

    }
}
