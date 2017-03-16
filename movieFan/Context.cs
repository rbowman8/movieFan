using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using movieFan.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace movieFan
{
    //public class Context : DbContext
    //{
    //    public Context() : base("MovieGallery")
    //    {
    //        Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
    //    }

    //    public DbSet<Movie> Movies { get; set; }
    //    public DbSet<Studio> Studios { get; set; }

    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    //    }
    //}
}