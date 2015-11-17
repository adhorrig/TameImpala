using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TameImpala.Models;

namespace TameImpala
{
    /// <summary>
    /// Summary description for TameImpalaService
    /// </summary>
    //[WebService(Namespace = "http://tempuri.org/")]
    //[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    //[System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class TameImpalaService : System.Web.Services.WebService
    {
        private TameImpalaContext db = new TameImpalaContext();
        [WebMethod]
        public List<UpcomingGig> GetAllGigs()
        {
            var gigs = new List<UpcomingGig>();

            foreach (var review in db.UpcomingGigs.ToList())
            {
                gigs.Add(review);
            }

            return gigs;

        }

        [WebMethod]
        public List<UpcomingGig> GetGigById(int id)
        {
            var gigs = db.UpcomingGigs.Where(u => u.UpcomingGigID == id).ToList();
            return gigs;
        }

        [WebMethod]
        public List<UpcomingGig> GetGigByLocation(string location)
        {
            var gigs = db.UpcomingGigs.Where(u => u.Location.Contains(location)).ToList();
            return gigs;
        }

        [WebMethod]
        public List<UpcomingGig> GetGigByPrice(int price)
        {
            var gigs = db.UpcomingGigs.Where(u => u.Price == price).ToList();
            return gigs;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
