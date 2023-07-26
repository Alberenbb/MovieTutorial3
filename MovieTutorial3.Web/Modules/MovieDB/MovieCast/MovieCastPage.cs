using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieTutorial3.MovieDB.Pages
{
    [PageAuthorize(typeof(MovieCastRow))]
    public class MovieCastPage : Controller
    {
        [Route("MovieDB/MovieCast")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/MovieCast/MovieCastIndex.cshtml");
        }
    }
}