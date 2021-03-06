using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Contract.Services;
using MovieStoreApp.WebMVC.Models;

namespace MovieStoreApp.WebMVC.Controllers
{
    public class MovieController : Controller
    {
        IMovieServiceAsync movieService;
        IMovieCastServiceAsync movieCastService;
        public MovieController(IMovieServiceAsync ser, IMovieCastServiceAsync service)
        {
            movieService = ser;
            movieCastService = service;

         }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "All Movies";

            //var result = await movieService.GetTop10RevenueMoviesAsync();
            return View();
        }

        public async Task <IActionResult> Detail(int movieId)
        {
            var result = await movieService.GetByIdAsync(movieId);
            result.MovieCasts = await movieCastService.GetAllByMovieIdAsync(movieId);
            return View(result);
        }

    }
}
