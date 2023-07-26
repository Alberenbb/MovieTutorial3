using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<MovieTutorial3.MovieDB.GenreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = MovieTutorial3.MovieDB.GenreRow;

namespace MovieTutorial3.MovieDB
{
    public interface IGenreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class GenreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGenreSaveHandler
    {
        public GenreSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}