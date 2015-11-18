namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TameImpala.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TameImpala.Models.TameImpalaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TameImpala.Models.TameImpalaContext";
        }

        protected override void Seed(TameImpala.Models.TameImpalaContext context)
        {
            context.UpcomingGigs.AddOrUpdate(x => x.UpcomingGigID,
                new UpcomingGig() { Title = "Test Title", Price = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new UpcomingGig() { Title = "Test Title", Price = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new UpcomingGig() { Title = "Test Title", Price = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new UpcomingGig() { Title = "Test Title", Price = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new UpcomingGig() { Title = "Test Title", Price = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new UpcomingGig() { Title = "Test Title", Price = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new UpcomingGig() { Title = "Test Title", Price = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new UpcomingGig() { Title = "Test Title", Price = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) }
                );


        }


    }
}
