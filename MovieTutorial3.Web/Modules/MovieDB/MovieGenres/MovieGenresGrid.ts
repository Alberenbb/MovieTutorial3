namespace MovieTutorial3.MovieDB {

    @Serenity.Decorators.registerClass('MovieTutorial3.MovieDB.MovieGenresGrid')
    export class MovieGenresGrid extends Serenity.EntityGrid<MovieGenresRow, any> {
        protected getDialogType() { return MovieGenresDialog; }
        protected getIdProperty() { return MovieGenresRow.idProperty; }
        protected getInsertPermission() { return MovieGenresRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieGenresRow.localTextPrefix; }
        protected getService() { return MovieGenresService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}