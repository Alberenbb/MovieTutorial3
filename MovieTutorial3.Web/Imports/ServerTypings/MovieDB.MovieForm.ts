namespace MovieTutorial3.MovieDB {
    export interface MovieForm {
        Title: Serenity.StringEditor;
        Description: Serenity.TextAreaEditor;
        PrimaryImage: Serenity.ImageUploadEditor;
        GalleryImages: Serenity.MultipleImageUploadEditor;
        Storyline: Serenity.TextAreaEditor;
        Year: Serenity.IntegerEditor;
        ReleaseDate: Serenity.DateEditor;
        GenreList: Serenity.LookupEditor;
        Runtime: Serenity.IntegerEditor;
        Kind: Serenity.EnumEditor;
    }

    export class MovieForm extends Serenity.PrefixedContext {
        static formKey = 'MovieDB.Movie';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!MovieForm.init)  {
                MovieForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.ImageUploadEditor;
                var w3 = s.MultipleImageUploadEditor;
                var w4 = s.IntegerEditor;
                var w5 = s.DateEditor;
                var w6 = s.LookupEditor;
                var w7 = s.EnumEditor;

                Q.initFormType(MovieForm, [
                    'Title', w0,
                    'Description', w1,
                    'PrimaryImage', w2,
                    'GalleryImages', w3,
                    'Storyline', w1,
                    'Year', w4,
                    'ReleaseDate', w5,
                    'GenreList', w6,
                    'Runtime', w4,
                    'Kind', w7
                ]);
            }
        }
    }
}