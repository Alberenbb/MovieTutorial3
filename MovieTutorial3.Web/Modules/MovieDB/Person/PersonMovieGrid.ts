﻿namespace MovieTutorial3.MovieDB {

    @Serenity.Decorators.registerClass('MovieTutorial3.MovieDB.PersonMovieGrid')
    export class PersonMovieGrid extends Serenity.EntityGrid<PersonRow, any> {
        protected getColumnsKey() { return PersonColumns.columnsKey; }
        protected getDialogType() { return PersonDialog; }
        protected getIdProperty() { return PersonRow.idProperty; }
        protected getInsertPermission() { return PersonRow.insertPermission; }
        protected getLocalTextPrefix() { return PersonRow.localTextPrefix; }
        protected getService() { return PersonService.baseUrl; }


        constructor(container: JQuery) {
            super(container);
        }
    }
}