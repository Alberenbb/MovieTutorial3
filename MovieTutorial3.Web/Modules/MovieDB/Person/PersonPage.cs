using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace MovieTutorial3.MovieDB.Pages
{
    [PageAuthorize(typeof(PersonRow))]
    public class PersonPage : Controller
    {
        [Route("MovieDB/Person")]
        public ActionResult Index()
        {
            return View("~/Modules/MovieDB/Person/PersonIndex.cshtml");
        }
    }
}