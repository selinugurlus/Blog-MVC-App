using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Blog_MVC_Application.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> Categories = new List<Category>()
            {
                new Category(){CategoryName="Tecnology"},
                new Category(){CategoryName="Fashion"},
                new Category(){CategoryName="Health"},
                new Category(){CategoryName="Sport"},
                new Category(){CategoryName="Entertain"}
             };

            foreach (var item in Categories)
            {
                context.Categories.Add(item);
            }

            context.SaveChanges();

            List<Blog> Blogs = new List<Blog>()
            {
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-10),Home=false,Confirm=true,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="1.jpg",CategoryId=1 },
                new Blog() {Title=" Dress Code ",Statement="Everything about Dress Code",UploadDate=DateTime.Now.AddDays(-8),Home=true,Confirm=true,Content="Everything about Dress CodeEverything about Dress CodeEverything about Dress CodeEverything about Dress Code",Image="1.jpg",CategoryId=1 },
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-1),Home=false,Confirm=true,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="2.jpg",CategoryId=2 },
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-4),Home=true,Confirm=false,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="2.jpg",CategoryId=2 },
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-45),Home=false,Confirm=true,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="2.jpg",CategoryId=2 },
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-3),Home=true,Confirm=false,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="3.jpg",CategoryId=3 },
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-1),Home=false,Confirm=true,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="3.jpg",CategoryId=3 },
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-6),Home=true,Confirm=false,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="3.jpg",CategoryId=3 },
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-1),Home=true,Confirm=true,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="4.jpg",CategoryId=4 },
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-34),Home=false,Confirm=true,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="4.jpg",CategoryId=4 },
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-100),Home=true,Confirm=true,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="5.jpg",CategoryId=5 },
                new Blog() {Title=" Machine Learning",Statement="Everything about ML",UploadDate=DateTime.Now.AddDays(-2),Home=false,Confirm=false,Content="Everything about MLEverything about MLEverything about MLEverything about ML",Image="5.jpg",CategoryId=5 },
            };

            foreach(var a in Blogs)
            {
                context.Blogs.Add(a);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}