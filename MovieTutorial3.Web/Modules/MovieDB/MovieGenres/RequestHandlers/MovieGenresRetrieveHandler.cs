using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieTutorial3.MovieDB.MovieGenresRow>;
using MyRow = MovieTutorial3.MovieDB.MovieGenresRow;

namespace MovieTutorial3.MovieDB
{
    public interface IMovieGenresRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieGenresRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresRetrieveHandler
    {
        public MovieGenresRetrieveHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}