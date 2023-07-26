using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<MovieTutorial3.MovieDB.MovieCastRow>;
using MyRow = MovieTutorial3.MovieDB.MovieCastRow;

namespace MovieTutorial3.MovieDB
{
    public interface IMovieCastRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastRetrieveHandler
    {
        public MovieCastRetrieveHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}