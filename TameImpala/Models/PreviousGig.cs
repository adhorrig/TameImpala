using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TameImpala.Models
{
    public class PreviousGig
    {
        public int PreviousGigID { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
    }
}