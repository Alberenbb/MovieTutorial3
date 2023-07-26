namespace MovieTutorial3.MovieDB {

    @Serenity.Decorators.registerClass('MovieTutorial3.MovieDB.MovieGenresDialog')
    export class MovieGenresDialog extends Serenity.EntityDialog<MovieGenresRow, any> {
        protected getIdProperty() { return MovieGenresRow.idProperty; }
        protected getLocalTextPrefix() { return MovieGenresRow.localTextPrefix; }
        protected getService() { return MovieGenresService.baseUrl; }
        protected getDeletePermission() { return MovieGenresRow.deletePermission; }
        protected getInsertPermission() { return MovieGenresRow.insertPermission; }
        protected getUpdatePermission() { return MovieGenresRow.updatePermission; }

    }
}