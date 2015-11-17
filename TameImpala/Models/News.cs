using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TameImpala.Models
{
    public class News
    {
        public int NewsID { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}