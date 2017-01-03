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
    public interface IFilmService
    {
        IEnumerable<Film> GetFilms();
        IEnumerable<Film> GetFilmsByVenue(int venueId);
        Film GetFilmByTitle(string name);
        Film GetFilm(int id);
        void CreateFilm(Film film);
        void SaveFilm();
    }

    public class FilmService : IFilmService
    {
        private readonly IFilmRepository filmRepository;
        private readonly IUnitOfWork unitOfWork;

        public FilmService(IFilmRepository filmRepository, IUnitOfWork unitOfWork)
        {
            this.filmRepository = filmRepository;
            this.unitOfWork = unitOfWork;
        }

        #region IFilmService Members
        public void CreateFilm(Film film)
        {
            filmRepository.Add(film);
        }

        public IEnumerable<Film> GetFilms()
        {
            var films = filmRepository.GetAll();
            return films;
        }

        public Film GetFilm(int id)
        {
            var film = filmRepository.GetById(id);
            return film;
        }

        public Film GetFilmByTitle(string title)
        {
            var film = filmRepository.Get(f => f.Title == title);
            return film;
        }

        public IEnumerable<Film> GetFilmsByVenue(int venueId)
        {
            var films = filmRepository.GetFilmsByVenue(venueId);
            return films;
        }
        public void SaveFilm()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
