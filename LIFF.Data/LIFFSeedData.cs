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
    public class LIFFSeedData : DropCreateDatabaseIfModelChanges<LIFFEntities>
    {
        protected override void Seed(LIFFEntities context)
        {
            GetCountries().ForEach(c => context.Countries.Add(c));
            GetVenues().ForEach(v => context.Venues.Add(v));
            GetDirectors().ForEach(d => context.Directors.Add(d));
            GetImagePaths().ForEach(i => context.ImagePaths.Add(i));
            GetFilms(context).ForEach(i => context.Films.Add(i));

            context.Commit();
        }

        private static List<Country> GetCountries()
        {
            return new List<Country>
            {
                new Country { Name = "UK" },
                new Country { Name = "USA" }
            };
        }

        private static List<Venue> GetVenues()
        {
            return new List<Venue>
            {
                new Venue { Name = "Victoria Hall" },
                new Venue { Name = "Vue The Light" }
            };
        }

        private static List<Director> GetDirectors()
        {
            return new List<Director>
            {
                new Director { Name = "Stanley Kubrick" },
                new Director { Name = "George Lucas" }
            };
        }

        private static List<ImagePath> GetImagePaths()
        {
            return new List<ImagePath>
            {
                new ImagePath { Path = "~/Content/Images/1349282020_2001_7.jpg" },
                new ImagePath { Path = "~/Content/Images/2001-2.jpg" },
                new ImagePath { Path = "~/Content/Images/2001-3.jpg" },
                new ImagePath { Path = "~/Content/Images/Star_wars_old.jpg" },
                new ImagePath { Path = "~/Content/Images/StarWars2.jpg" },
                new ImagePath { Path = "~/Content/Images/StarWars3.jpg" }
            };
        }

        private static List<Film> GetFilms(LIFFEntities context)
        {
            return new List<Film>
            {
                new Film
                {
                    Title = "2001: a Space Odyssey",
                    Country = (List<Country>)context.Countries.Select(c => c.CountryId == 1),
                    Description = "Epic science fiction.",
                    Director = (List<Director>)context.Directors.Select(d => d.DirectorId == 1),
                    Year = 1968,
                    TrailerURL = "https://www.youtube.com/watch?v=lfF0vxKZRhc",
                    RunningTime = 121,
                    Subtitles = false,
                    Images = (List<ImagePath>)context.ImagePaths.Select(i => i.ImagePathId >= 1 && i.ImagePathId <= 3)
                },
                new Film
                {
                    Title = "Star Wars Episode IV: A New Hope",
                    Country = (List<Country>)context.Countries.Select(c => c.CountryId == 2),
                    Description = "Epic space opera.",
                    Director = (List<Director>)context.Directors.Select(d => d.DirectorId == 2),
                    Year = 1977,
                    TrailerURL = "https://www.youtube.com/watch?v=1g3_CFmnU7k",
                    RunningTime = 116,
                    Subtitles = false,
                    Images = (List<ImagePath>)context.ImagePaths.Select(i => i.ImagePathId >= 4 && i.ImagePathId <= 6)
                }
            };

        }
    }
}
