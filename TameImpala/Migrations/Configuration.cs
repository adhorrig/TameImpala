namespace TameImpala.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TameImpala.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TameImpala.Models.TameImpalaContext>
    {
        private TameImpalaContext dbconn = new TameImpalaContext();
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TameImpala.Models.TameImpalaContext";
        }

        protected override void Seed(TameImpala.Models.TameImpalaContext context)
        {

            context.Arcticles.AddOrUpdate(x => x.ArticleID, //I know I spelled arcticle wrong
                new Article() { url = "http://www.nzherald.co.nz/entertainment/news/article.cfm?c_id=1501119&objectid=11551071", title = "Concert Review", description = "Logan Campbell Centre" },
                new Article() { url = "http://themusic.com.au/news/all/2015/11/25/tame-impala-courtney-barnett-named-on-qs-influential-top-albums-list/", title = "Album Reward", description = "Tame Impala Top Influential Albums Of The Year List" },
                new Article() { url = "http://www.smh.com.au/entertainment/tame-impala-review-psychedelia-and-sway-for-all-ages-20151122-gl4s1h.html", title = "Review", description = "Tame Impala review: psychedelia and sway for all ages" }
                );

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

            context.PreviousGigs.AddOrUpdate(x => x.PreviousGigID,
                new PreviousGig() { Title = "Test Title", Rating = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new PreviousGig() { Title = "Test Title", Rating = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new PreviousGig() { Title = "Test Title", Rating = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new PreviousGig() { Title = "Test Title", Rating = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new PreviousGig() { Title = "Test Title", Rating = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new PreviousGig() { Title = "Test Title", Rating = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new PreviousGig() { Title = "Test Title", Rating = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) },
                new PreviousGig() { Title = "Test Title", Rating = 50, Description = "Test Description", Location = "Test Location", Date = new DateTime(2015, 5, 15, 13, 45, 0) }
                );



        }


    }
}
