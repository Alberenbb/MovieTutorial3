using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace MovieTutorial3.MovieDB.Columns
{
    [ColumnsScript("MovieDB.Person")]
    [BasedOnRow(typeof(PersonRow), CheckNames = true)]
    public class PersonColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int PersonId { get; set; }
        [EditLink]
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public Gender Gender { get; set; }
        public int Height { get; set; }
        public string PrimaryImage { get; set; }
        public string GalleryImages { get; set; }
    }
}