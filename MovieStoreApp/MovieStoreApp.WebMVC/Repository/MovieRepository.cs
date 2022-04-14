using MovieStoreApp.WebMVC.Models;
namespace MovieStoreApp.WebMVC.Repository
{
    public class MovieRepository
    {
        List<MovieModel> Movies;

        public MovieRepository()
        {
            Movies = new List<MovieModel>()
            {
                new MovieModel(){ Id = 1, PosterURL="https://m.media-amazon.com/images/I/61oZCgGR2eL._AC_SY450_.jpg", Title = "Star Wars episode 1", Duration=165, ReleaseDate= DateTime.Now.AddYears(-5).ToShortDateString(), Description="lorem fdf vev rfvd vdfv grbvg bgd bdb dfb fdb fb"},
                new MovieModel() { Id = 2, PosterURL = "https://m.media-amazon.com/images/I/61oZCgGR2eL._AC_SY450_.jpg", Title = "Narnia", Duration = 165, ReleaseDate = DateTime.Now.AddYears(-5).ToShortDateString(), Description = "lorem fdf vev rfvd vdfv grbvg bgd bdb dfb fdb fb" },
                new MovieModel() { Id = 3, PosterURL = "https://m.media-amazon.com/images/I/61oZCgGR2eL._AC_SY450_.jpg", Title = "Die Hard", Duration = 165, ReleaseDate = DateTime.Now.AddYears(-5).ToShortDateString(), Description = "lorem fdf vev rfvd vdfv grbvg bgd bdb dfb fdb fb" },
            };
        }

        public IEnumerable<MovieModel> GetAll()
        {
            return Movies;
        }

        public MovieModel GetById(int id)
        {
            return Movies.Where(x => x.Id==id).FirstOrDefault();
        }
    }
}
