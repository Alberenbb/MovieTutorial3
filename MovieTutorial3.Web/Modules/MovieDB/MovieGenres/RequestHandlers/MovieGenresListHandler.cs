using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieTutorial3.MovieDB.MovieGenresRow>;
using MyRow = MovieTutorial3.MovieDB.MovieGenresRow;

namespace MovieTutorial3.MovieDB
{
    public interface IMovieGenresListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieGenresListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresListHandler
    {
        public MovieGenresListHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}