using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_MVC_Application.Models
{
    public class CategoryModel
    {   public int Id { get; set; }
        public string CategoryName { get; set; }
        public int BlogCount { get; set; }
    }
}