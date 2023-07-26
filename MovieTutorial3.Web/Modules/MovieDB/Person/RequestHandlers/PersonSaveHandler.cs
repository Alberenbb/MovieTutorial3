using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<MovieTutorial3.MovieDB.PersonRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieTutorial3.MovieDB.PersonRow;

namespace MovieTutorial3.MovieDB
{
    public interface IPersonSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PersonSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPersonSaveHandler
    {
        public PersonSaveHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}