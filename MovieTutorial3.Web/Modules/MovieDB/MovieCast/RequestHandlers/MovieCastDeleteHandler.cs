﻿using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = MovieTutorial3.MovieDB.MovieCastRow;

namespace MovieTutorial3.MovieDB
{
    public interface IMovieCastDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieCastDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IMovieCastDeleteHandler
    {
        public MovieCastDeleteHandler(IRequestContext context)
                : base(context)
        {
        }
    }
}