using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<MovieTutorial3.MovieDB.PersonRow>;
using MyRow = MovieTutorial3.MovieDB.PersonRow;

namespace MovieTutorial3.MovieDB
{
    public interface IPersonListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class PersonListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPersonListHandler
    {
        public PersonListHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}