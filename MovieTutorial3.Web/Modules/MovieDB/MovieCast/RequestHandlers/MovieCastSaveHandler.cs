using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieTutorial3.MovieDB.MovieCastRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieTutorial3.MovieDB.MovieCastRow;

namespace MovieTutorial3.MovieDB
{
    public interface IMovieCastSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastSaveHandler
    {
        public MovieCastSaveHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}