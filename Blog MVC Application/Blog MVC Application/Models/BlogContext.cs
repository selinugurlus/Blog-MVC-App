﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Blog_MVC_Application.Models
{
    public class BlogContext:DbContext
    {
        public BlogContext()
        {
            Database.SetInitializer(new BlogInitializer()); 
        }
        public DbSet<Blog>Blogs  { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}