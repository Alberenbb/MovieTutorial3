﻿using Serenity.ComponentModel;

namespace MovieTutorial3.MovieDB.Forms
{
    [FormScript("MovieDB.MovieGenres")]
    [BasedOnRow(typeof(MovieGenresRow), CheckNames = true)]
    public class MovieGenresForm
    {
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}