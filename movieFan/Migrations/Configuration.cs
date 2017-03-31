namespace movieFan.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using movieModel.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<movieFan.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "movieFan.Models.MovieDBContext";
        }

        protected override void Seed(movieFan.Models.MovieDBContext context)
        {
            MovieDBContext.Movie.AddOrUpdate(
                m => m.Name,
                new Movie() { MovieName = "Alien"},
                new Movie() { MovieName = "Crash"}
                );
        }
    }
}
