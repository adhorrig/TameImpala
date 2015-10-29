using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TameImpala.Models
{
    public class TameImpalaContext : DbContext
    {
        public TameImpalaContext() : base("TameImpalaContext")
        {
            
        }

        public DbSet<FavoriteGig> FavoriteGigs { get; set; }
        public DbSet<UpcomingGig> UpcomingGigs { get; set; }
        public DbSet<PreviousGig> PreviousGigs { get; set; }
        public DbSet<GoingToGig> GoingToGigs { get; set; }
    }
}