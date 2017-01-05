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
    public class HomeController : Controller
    {
        private readonly IFilmService filmService;

        public HomeController(IFilmService filmService)
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
    }
}