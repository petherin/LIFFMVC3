using LIFF.Data.Infrastructure;
using LIFF.Data.Repositories;
using LIFF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIFF.Service
{
    public interface IDirectorService
    {
        IEnumerable<Director> GetDirectors();
        IEnumerable<Director> GetDirectorsByFilm(int filmId);
        Director GetDirectorByName(string name);
        Director GetDirector(int id);
        void CreateDirector(Director director);
        void SaveDirector();
    }

    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository directorRepository;
        private readonly IUnitOfWork unitOfWork;

        public DirectorService(IDirectorRepository directorRepository, IUnitOfWork unitOfWork)
        {
            this.directorRepository = directorRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IDirectorService Members
        public void CreateDirector(Director director)
        {
            directorRepository.Add(director);
        }

        public IEnumerable<Director> GetDirectors()
        {
            var directors = directorRepository.GetAll();
            return directors;
        }

        public Director GetDirector(int id)
        {
            var director = directorRepository.GetById(id);
            return director;
        }
        public Director GetDirectorByName(string name)
        {
            var director = directorRepository.Get(d => d.Name == name);
            return director;
        }

        public IEnumerable<Director> GetDirectorsByFilm(int filmId)
        {
            var directors = directorRepository.GetDirectorsByFilm(filmId);
            return directors;
        }

        public void SaveDirector()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
