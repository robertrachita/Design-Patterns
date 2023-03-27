using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DesignPatterns_SocialMedia.Models;

namespace DesignPatterns_SocialMedia.Controllers
{
    public abstract class PostCreator : Controller
    {
        public abstract Post CreatePost(String content, String title);
      

        //generated logic, not sure if needed but I'll leave it here for now
        
        // GET: PostCreator
        public ActionResult Index()
        {
            return View();
        }

        // GET: PostCreator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PostCreator/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostCreator/Create
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

        // GET: PostCreator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PostCreator/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: PostCreator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostCreator/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
