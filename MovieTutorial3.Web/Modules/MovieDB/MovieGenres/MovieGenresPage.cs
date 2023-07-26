using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieTutorial3.MovieDB.Pages
{
    [PageAuthorize(typeof(MovieGenresRow))]
    public class MovieGenresPage : Controller
    {
        [Route("MovieDB/MovieGenres")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/MovieGenres/MovieGenresIndex.cshtml");
        }
    }
}