using AutoMapper;
using LIFF.Model;
using LIFF.Service;
using LIFF.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LIFF.Web.Controllers
{
    public class FilmController : Controller
    {
        private readonly IFilmService filmService;

        public FilmController(IFilmService filmService)
        {
            this.filmService = filmService;
        }

        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<Film> films;
            IEnumerable<FilmViewModel> filmsViewModel;

            films = filmService.GetFilms().ToList();
            filmsViewModel = Mapper.Map<IEnumerable<Film>, IEnumerable<FilmViewModel>>(films);
            return View(filmsViewModel);
        }

        public ActionResult Details(int id)
        {
            Film film;
            FilmViewModel filmViewModel;

            film = filmService.GetFilm(id);
            filmViewModel = Mapper.Map<Film, FilmViewModel>(film);
            return View(filmViewModel);
        }
    }
}