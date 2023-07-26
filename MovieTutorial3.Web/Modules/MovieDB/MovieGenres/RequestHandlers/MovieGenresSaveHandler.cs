using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieTutorial3.MovieDB.MovieGenresRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieTutorial3.MovieDB.MovieGenresRow;

namespace MovieTutorial3.MovieDB
{
    public interface IMovieGenresSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieGenresSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresSaveHandler
    {
        public MovieGenresSaveHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}