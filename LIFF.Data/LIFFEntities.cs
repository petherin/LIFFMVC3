using LIFF.Data.Configuration;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data
{
    public class LIFFEntities : DbContext
    {
        public LIFFEntities() : base("LIFFEntities") { }

        public DbSet<Film> Films { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<TimeSlot> Slots { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<ImagePath> ImagePaths { get; set; }
        public DbSet<NewsItem> NewsItems { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new DirectorConfiguration());
            modelBuilder.Configurations.Add(new FilmConfiguration());
            modelBuilder.Configurations.Add(new ImagePathConfiguration());
            modelBuilder.Configurations.Add(new TimeSlotConfiguration());
            modelBuilder.Configurations.Add(new VenueConfiguration());
            modelBuilder.Configurations.Add(new NewsItemConfiguration());
        }
    }
}
