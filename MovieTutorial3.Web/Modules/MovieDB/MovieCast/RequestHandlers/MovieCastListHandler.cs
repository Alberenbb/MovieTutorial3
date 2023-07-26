using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieTutorial3.MovieDB.MovieCastRow>;
using MyRow = MovieTutorial3.MovieDB.MovieCastRow;

namespace MovieTutorial3.MovieDB
{
    public interface IMovieCastListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastListHandler
    {
        public MovieCastListHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}