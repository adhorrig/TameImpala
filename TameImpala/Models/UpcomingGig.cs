using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TameImpala.Models
{
    public class UpcomingGig
    {
        public int UpcomingGigID { get; set; }
        public string Location { get; set; }
        public double Price { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
    }
}