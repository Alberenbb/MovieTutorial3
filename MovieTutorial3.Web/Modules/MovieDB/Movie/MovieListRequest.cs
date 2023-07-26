using Serenity.Services;
using System.Collections.Generic;

namespace MovieTutorial3.MovieDB
{
    public class MovieListRequest : ListRequest
    {
        public List<int> Genres { get; set; }
    }
}