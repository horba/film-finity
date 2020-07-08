using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.DTO
{
    public class MovieDetailsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public List<string> Countries { get; set; }
        public int DurationMinutes { get; set; }
        public float Rate { get; set; }
        public Dictionary<string, double> Rates { get; set; }
        public int ReleaseYear { get; set; }
        public string PosterImageSource { get; set; }
        public string Description { get; set; }
        public ICollection<GenreDTO> Genres { get; set; }
        public ICollection<string> Directors { get; set; }
        public ICollection<string> Produsers { get; set; }
        public ICollection<string> Writers { get; set; }
        public string ProductionDesigner { get; set; }
        public FilmAgeRatingDTO FilmAgeRating { get; set; }
        public VideoFileDTO VideoFile { get; set; }
        public ICollection<string> FramesImageSource { get; set; }
    }
}
