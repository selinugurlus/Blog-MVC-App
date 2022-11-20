using Blog_MVC_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVC_Application.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext context = new BlogContext();
        // GET: Home
        public ActionResult Index()
        {
            var blogs = context.Blogs
                .Select(i=>new BlogModel()
                {
                    Id=i.Id,
                    Title=i.Title.Length>100?i.Title.Substring(0,100)+"...":i.Title,
                    Statement=i.Statement,
                    UploadDate=i.UploadDate,
                    Home=i.Home,
                    Confirm=i.Confirm,
                    Image=i.Image

                })
                .Where(i => i.Confirm == true && i.Home == true);

            return View(blogs.ToList());
        }
    }
}