using LIFF.Data.Infrastructure;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Repositories
{
    public class FilmRepository : RepositoryBase<Film>, IFilmRepository
    {
        public FilmRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<Film> GetFilmsByVenue(int venueId)
        {
            var venue = this.DbContext.Venues.Where(v => v.VenueId == venueId).FirstOrDefault();

            var films = this.DbContext.Films.Where(d => d.Venues.Contains(venue)).ToList();

            return films;
        }
    }

    public interface IFilmRepository : IRepository<Film>
    {
        IEnumerable<Film> GetFilmsByVenue(int venueId);
    }
}