namespace MovieTutorial3.MovieDB {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'MovieTutorial3.MovieDB.MovieKind', 'MovieDB.MovieKind');
}
