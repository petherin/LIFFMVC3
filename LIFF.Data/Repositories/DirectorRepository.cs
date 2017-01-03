using LIFF.Data.Infrastructure;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Data.Repositories
{
    public class DirectorRepository : RepositoryBase<Director>, IDirectorRepository
    {
        public DirectorRepository(IDbFactory dbFactory) : base(dbFactory) { }

        public IEnumerable<Director> GetDirectorsByFilm(int filmId)
        {
            var film = this.DbContext.Films.Where(f => f.FilmId == filmId).FirstOrDefault();

            var directors = this.DbContext.Directors.Where(d => d.Films.Contains(film)).ToList();

            return directors;
        }
    }

    public interface IDirectorRepository : IRepository<Director>
    {
        IEnumerable<Director> GetDirectorsByFilm(int filmId);
    }

}
