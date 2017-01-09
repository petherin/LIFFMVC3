using LIFF.Data.Infrastructure;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Repositories
{
    public class VenueRepository : RepositoryBase<Venue>, IVenueRepository
    {
        public VenueRepository(IDbFactory dbFactory) : base(dbFactory) { }

        //public IEnumerable<Venue> GetVenuesByFilm(int filmId)
        //{
        //    var film = this.DbContext.Films.Where(f => f.FilmId == filmId).FirstOrDefault();
        //    var venues = this.DbContext.Venues.Where(v => v.Films.Contains(film)).ToList();

        //    return venues;
        //}
    }

    public interface IVenueRepository : IRepository<Venue>
    {
        //IEnumerable<Venue> GetVenuesByFilm(int filmId);
    }
}