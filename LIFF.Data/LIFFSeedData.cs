using LIFF.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data
{
    public class LIFFSeedData : DropCreateDatabaseAlways<LIFFEntities>
    {
        protected override void Seed(LIFFEntities context)
        {
            //if (System.Diagnostics.Debugger.IsAttached == false)
            //    System.Diagnostics.Debugger.Launch();

            GetFilms(context).ForEach(f => context.Films.Add(f));

            context.Commit();
        }

        private static List<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country { CountryId=1, Name = "UK" },
                new Country { CountryId=2, Name = "USA" }
            };
        }

        private static List<Venue> GetVenues()
        {
            return new List<Venue>
            {
                new Venue { VenueId=1, Name = "Victoria Hall" },
                new Venue { VenueId=2,Name = "Vue The Light" }
            };
        }

        private static List<Director> GetDirectors()
        {
            return new List<Director>
            {
                new Director {DirectorId=1, Name = "Stanley Kubrick" },
                new Director {DirectorId=2, Name = "George Lucas" }
            };
        }

        private static List<ImagePath> GetImagePaths()
        {
            return new List<ImagePath>
            {
                new ImagePath { ImagePathId = 1, Path = "~/Content/Images/1349282020_2001_7.jpg" },
                new ImagePath { ImagePathId = 2, Path = "~/Content/Images/2001-2.jpg" },
                new ImagePath { ImagePathId = 3, Path = "~/Content/Images/2001-3.jpg" },
                new ImagePath { ImagePathId = 4,  Path = "~/Content/Images/Star_wars_old.jpg" },
                new ImagePath { ImagePathId = 5,  Path = "~/Content/Images/StarWars2.jpg" },
                new ImagePath { ImagePathId = 6, Path = "~/Content/Images/StarWars3.jpg" }
            };
        }

        private static List<Film> GetFilms(LIFFEntities context)
        {
            List<Film> films = new List<Film>();

            Film film1 = new Film
            {
                Title = "2001: a Space Odyssey",
                Country = new List<Country>(),
                Description = "Epic science fiction.",
                Director = new List<Director>(),
                Year = 1968,
                TrailerURL = "https://www.youtube.com/watch?v=lfF0vxKZRhc",
                RunningTime = 121,
                Subtitles = false,
                Images = new List<ImagePath>(),
                Venues = new List<Venue>(),
                Certificate = "U"
            };

            Film film2 = new Film
            {
                Title = "Star Wars Episode IV: A New Hope",
                Country = new List<Country>(),
                Description = "Epic space opera.",
                Director = new List<Director>(),
                Year = 1977,
                TrailerURL = "https://www.youtube.com/watch?v=1g3_CFmnU7k",
                RunningTime = 116,
                Subtitles = false,
                Images = new List<ImagePath>(),
                Venues = new List<Venue>(),
                Certificate = "U"
            };

            List<ImagePath> images = GetImagePaths();
            List<Country> countries = GetCountries();
            List<Director> directors = GetDirectors();
            List<Venue> venues = GetVenues();

            film1.Images.AddRange(images.Where(i => i.ImagePathId >= 1 && i.ImagePathId <= 3).ToList());
            film2.Images.AddRange(images.Where(i => i.ImagePathId >= 4 && i.ImagePathId <= 6).ToList());

            film1.Country.AddRange(countries.Where(c => c.CountryId == 1 || c.CountryId == 2).ToList());
            film2.Country.AddRange(countries.Where(c => c.CountryId == 2).ToList());

            film1.Director.AddRange(directors.Where(c => c.DirectorId == 1).ToList());
            film2.Director.AddRange(directors.Where(c => c.DirectorId == 2).ToList());

            film1.Venues.AddRange(venues.Where(c => c.VenueId == 1).ToList());
            film2.Venues.AddRange(venues.Where(c => c.VenueId == 2).ToList());

            films.Add(film1);
            films.Add(film2);

            return films;
        }
    }
}
