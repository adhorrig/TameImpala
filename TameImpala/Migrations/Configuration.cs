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
            context.Articles.AddOrUpdate(x => x.ArticleID, 
                new Article() { URL = "http://www.nzherald.co.nz/entertainment/news/article.cfm?c_id=1501119&objectid=11551071", Title = "Concert Review", Description = "Logan Campbell Centre" },
                new Article() { URL = "http://themusic.com.au/news/all/2015/11/25/tame-impala-courtney-barnett-named-on-qs-influential-top-albums-list/", Title = "Album Reward", Description = "Tame Impala Top Influential Albums Of The Year List" },
                new Article() { URL = "http://www.smh.com.au/entertainment/tame-impala-review-psychedelia-and-sway-for-all-ages-20151122-gl4s1h.html", Title = "Review", Description = "Tame Impala review: psychedelia and sway for all ages" }
                );

            context.Videos.AddOrUpdate(x => x.VideoID,
                new Video() { VideoTitle = "The Less I Know The Better", VideoURL = "https://www.youtube.com/embed/sBzrzS1Ag_g" },
                new Video() { VideoTitle = "Eventually", VideoURL = "https://www.youtube.com/embed/GHe8kKO8uds" },
                new Video() { VideoTitle = "Half Glass Full of Wine", VideoURL = "https://www.youtube.com/embed/zfcHq0hhFWg" },
                new Video() { VideoTitle = "Elephant", VideoURL = "https://www.youtube.com/embed/b0jqPvpn3sY" }

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
