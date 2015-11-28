using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TameImpala.Models
{
    public class Article
    {
        public int ArticleID { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}