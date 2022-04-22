using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.Core.Contract.Services;

namespace MovieStoreApp.WebMVC.Component
{
    public class AllGenresViewComponent : ViewComponent
    {
        IGenreServiceAsync GenreService;
        public AllGenresViewComponent(IGenreServiceAsync ser)
        {
            GenreService = ser;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var result = await GenreService.GetAllGenreAsync();
            return View("allgenres", result);
        }
    }
}

