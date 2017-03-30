using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace movieFan.Models
{

    



public class Movie
    {

        public int Id { get; set; }
        //  place movie art here        public string Picture { get; set; }
        [Display(Name = "Movie Name")]
        public string MovieName { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public string Actors { get; set; }
        public string Description { get; set; }
        public bool Like { get; set; }

    }

    public class Studio

    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
    }

    public class MovieDBContext : DbContext
    {

        public MovieDBContext()
        {
              Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MovieDBContext>());
        //    //Database.SetInitializer(new CreateDatabaseIfNotExist<MovieDBContext>());
        //    Database.SetInitializer(new DropCreateDatabaseAlways<MovieDBContext>());
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Studio> Studios { get; set; }
    }


   

    
}
