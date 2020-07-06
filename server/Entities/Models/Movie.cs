using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public List<string> Countries { get; set; }
        public int DurationMinutes { get; set; }
        public float Rate { get; set; }
        public int ReleaseYear { get; set; }
        public string PosterImageSource { get; set; }
        public ICollection<MovieGenre> Genres { get; set; }
        public ICollection<Celebrity> Directors { get; set; }
        public ICollection<Celebrity> Produsers { get; set; }
        public string ProductionDesigner { get; set; }
        public FilmAgeRating AgeRating { get; set; }
        public VideoFile VideoFile { get; set; }
        public ICollection<string> FramesImageSource { get; set; }
        public ICollection<Celebrity> Actors { get; set; }
        public ICollection<ActorsList> ActorsList { get; set; }

    }
}
