using System.ComponentModel.DataAnnotations;

namespace Movie_blazor.Components.Movies
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Release_date { get; set; }
        public float? Rate { get; set; }
        public int? how_many_have_rated { get; set; }

        public string? URL { get; set; }
    }
}
