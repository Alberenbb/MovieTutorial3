namespace MovieTutorial3.MovieDB {

    @Serenity.Decorators.registerClass('MovieTutorial3.MovieDB.MovieCastGrid')
    export class MovieCastGrid extends Serenity.EntityGrid<MovieCastRow, any> {
        protected getColumnsKey() { return MovieCastColumns.columnsKey; }
        protected getDialogType() { return MovieCastDialog; }
        protected getIdProperty() { return MovieCastRow.idProperty; }
        protected getInsertPermission() { return MovieCastRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieCastRow.localTextPrefix; }
        protected getService() { return MovieCastService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}