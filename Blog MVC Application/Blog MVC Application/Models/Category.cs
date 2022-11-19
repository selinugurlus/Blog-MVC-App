using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_MVC_Application.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<Blog> Blogs { get; set; } 
    }
}